using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscTest.CustomControls
{
    public class CheckGroupBox : GroupBox
    {
        /// <summary>
        /// RadioButtonを縦に並べるためにFlowLayoutPanelを使用します。
        /// </summary>
        private readonly FlowLayoutPanel panel = new();

        /// <summary>
        /// RadioButtonのCheckChangedイベントを橋渡しするイベント。
        /// </summary>
        public event EventHandler? CheckedChanged;

        /// <summary>
        /// 内部管理用のCheckBoxリスト。
        /// </summary>
        private readonly List<CheckBox> checkBoxes = [];

        /// <summary>
        /// CheckBoxの数を取得する。
        /// </summary>
        public int ItemCount => checkBoxes.Count;


        /// <summary>
        /// コンストラクタ
        /// </summary>
        public CheckGroupBox()
        {
            PanelInitialize();
        }

        /// <summary>
        /// FlowLayoutPanelを初期化してGroupBoxに追加する。
        /// </summary>
        private void PanelInitialize()
        {
            panel.Dock = DockStyle.Fill;
            panel.FlowDirection = FlowDirection.TopDown;
            panel.WrapContents = false;
            panel.AutoSize = true;
            this.Controls.Add(panel);
        }

        /// <summary>
        /// 自動サイズ調整を有効化。
        /// </summary>
        /// <param name="autoSize"></param>
        public void ToAutoSize(bool autoSize)
        {
            this.AutoSize = autoSize;
            this.AutoSizeMode = autoSize ? AutoSizeMode.GrowAndShrink : AutoSizeMode.GrowOnly;
        }

        /// <summary>
        /// パネルのFlowDirectionを設定する。
        /// </summary>
        public FlowDirection FlowDirection
        { 
            get => panel.FlowDirection; 
            set => panel.FlowDirection = value;
        }

        /// <summary>
        /// CheckBoxを追加する。
        /// </summary>
        /// <param name="text"></param>
        /// <param name="tag"></param>
        public void AddItem(string text, object? tag = null, bool chk = false)
        {
            // CheckBoxを作成してFlowLayoutPanelに追加
            var checkBox = new CheckBox
            {
                Text = text,
                Tag = tag,
                Checked = chk,
                AutoSize = true
            };
            checkBox.CheckedChanged += (s, e) => CheckedChanged?.Invoke(s, e);
            checkBoxes.Add(checkBox);
            panel.Controls.Add(checkBox);
        }

        /// <summary>
        /// 全部ON
        /// </summary>
        public void CheckAll() => checkBoxes.ForEach(cb => cb.Checked = true);

        /// <summary>
        /// 全部OFF
        /// </summary>
        public void UncheckAll() => checkBoxes.ForEach(cb => cb.Checked = false);

        /// <summary>
        /// チェックボックスにアクセスできる。
        /// </summary>
        public IReadOnlyList<CheckBox> Items => checkBoxes;


    }
}
