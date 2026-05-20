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
            // Tag が指定されていない場合は自動採番
            if (tag == null)
            {
                tag = itemCounter++;
            }
            var rb = new RadioButton
            {
                Text = text,
                Tag = tag
            };
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
    }
}
