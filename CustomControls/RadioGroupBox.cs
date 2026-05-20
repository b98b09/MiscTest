using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiscTest.CustomControls
{
    /// <summary>
    /// RadioButton専用のGroupBox。
    /// GroupBox内にFlowLayoutPanelを配置してRadioButtonを縦に並べることができます。
    /// </summary>
    public class RadioGroupBox : GroupBox
    {
        /// <summary>
        /// RadioButtonを縦に並べるためにFlowLayoutPanelを使用します。
        /// </summary>
        private readonly FlowLayoutPanel panel;

        /// <summary>
        /// RadioButtonのCheckChangedイベントを橋渡しするイベント。
        /// </summary>
        public event EventHandler? CheckedChanged;

        /// <summary>
        /// AddItemでTagが指定されない場合の自動採番用カウンタ。
        /// </summary>
        private int itemCounter = 0;

        /// <summary>
        /// RadioButton専用のGroupBoxを作ります。
        /// </summary>
        public RadioGroupBox()
        {
            // AutoSizeをオンにして高さを内容に合わせる
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            // FlowLayoutPanelを作成してGroupBoxに追加
            panel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false
            };
            Controls.Add(panel);
        }

        /// <summary>
        /// RadioButtonを追加する。
        /// </summary>
        /// <param name="text"></param>
        /// <param name="tag"></param>
        public void AddItem(string text, object? tag = null)
        {
            // Tag自動連番
            if (tag == null)
            {
                tag = itemCounter++;
            }
            var rb = new RadioButton
            {
                Text = text,
                Tag = tag
            };

            // AutoSizeをオフにして幅をテキストの幅に合わせる
            rb.AutoSize = false;
            rb.Width = TextRenderer.MeasureText(text, rb.Font).Width + 24;

            rb.CheckedChanged += (s, e) =>
            {
                if ((s is RadioButton r) && (r.Checked))
                {
                    CheckedChanged?.Invoke(s, e);
                }
            };
            panel.Controls.Add(rb);
        }




        /// <summary>
        /// 選択中のRadioButtonを取得する。
        /// </summary>
        public RadioButton? CheckedItem
        {
            get
            {
                return panel.Controls
                    .OfType<RadioButton>()
                    .FirstOrDefault(rb => rb.Checked);
            }
        }

        /// <summary>
        /// 選択中のRadioButtonのTagを取得する。
        /// </summary>
        public object? CheckedTag
        {
            get
            {
                return CheckedItem?.Tag;
            }
        }

        /// <summary>
        /// 選択中のRadioButtonのインデックスを取得する。
        /// </summary>
        public int CheckedIndex
        {
            get
            {
                var rb = CheckedItem;
                if (rb == null) return -1;

                return panel.Controls
                    .OfType<RadioButton>()
                    .ToList()
                    .IndexOf(rb);
            }
        }



        private RadioButton[] Items
        {
            get
            {
                return panel.Controls
                    .OfType<RadioButton>()
                    .ToArray();
            }
        }

        private int CurrentIndex
        {
            get
            {
                var items = Items;
                for (int i = 0; i < items.Length; i++)
                {
                    if (items[i].Checked)
                        return i;
                }
                return -1; // 何も選ばれていない
            }
        }

        public void SelectNext()
        {
            var items = Items;
            int idx = CurrentIndex;

            if (items.Length == 0)
                return;

            // 何も選ばれていない → 最初を選ぶ
            if (idx < 0)
            {
                items[0].Checked = true;
                return;
            }

            // 最後 → 何もしない（またはループさせるなら idx = -1 にする）
            if (idx >= items.Length - 1)
                return;

            items[idx + 1].Checked = true;
        }

        public void SelectPrevious()
        {
            var items = Items;
            int idx = CurrentIndex;

            if (items.Length == 0)
                return;

            // 何も選ばれていない → 最後を選ぶ
            if (idx < 0)
            {
                items[items.Length - 1].Checked = true;
                return;
            }

            // 最初 → 何もしない（またはループさせるなら idx = items.Length にする）
            if (idx == 0)
                return;

            items[idx - 1].Checked = true;
        }



        /// <summary>
        /// 全てのRadioButtonの選択状態をクリアする。
        /// </summary>
        public void ClearSelection()
        {
            for (int i = 0; i < panel.Controls.Count; i++)
            {
                if (panel.Controls[i] is RadioButton rb)
                    rb.Checked = false;
            }
        }

    }
}
