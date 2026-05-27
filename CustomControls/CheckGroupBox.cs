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

        private readonly List<CheckBox> checkBoxes = [];

        public int ItemCount { get; internal set; }


        public CheckGroupBox()
        {
            // AutoSizeをオンにして高さを内容に合わせる
            // this.AutoSize = true;
            // this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            // FlowLayoutPanelを作成してGroupBoxに追加
            Initialize();
        }


        private void Initialize()
        {
            panel.Dock = DockStyle.Fill;
            panel.FlowDirection = FlowDirection.TopDown;
            panel.WrapContents = false;
            panel.AutoSize = true;
            this.Controls.Add(panel);
        }

        public void ToAutoSize(bool autoSize)
        {
            this.AutoSize = autoSize;
            this.AutoSizeMode = autoSize ? AutoSizeMode.GrowAndShrink : AutoSizeMode.GrowOnly;
        }

        public FlowDirection FlowDirection
        { 
            get => panel.FlowDirection; 
            set => panel.FlowDirection = value;
        }

        public void AddItem(string text, object? tag = null)
        {
            // CheckBoxを作成してFlowLayoutPanelに追加
            var checkBox = new CheckBox
            {
                Text = text,
                Tag = tag
            };
            checkBox.CheckedChanged += (s, e) => CheckedChanged?.Invoke(s, e);
            checkBoxes.Add(checkBox);
            panel.Controls.Add(checkBox);
            ItemCount++;
        }

        /// <summary>
        /// 全部ON
        /// </summary>
        public void CheckAll() => checkBoxes.ForEach(cb => cb.Checked = true);

        /// <summary>
        /// 全部OFF
        /// </summary>
        public void UncheckAll() => checkBoxes.ForEach(cb => cb.Checked = false);
    }
}
