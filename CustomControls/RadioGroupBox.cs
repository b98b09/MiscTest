using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private readonly FlowLayoutPanel flowLayoutPanel;

        /// <summary>
        /// RadioButtonのCheckChangedイベントを橋渡しするイベント。
        /// </summary>
        public event EventHandler? CheckedChanged;

        /// <summary>
        /// RadioButton専用のGroupBoxを作ります。
        /// </summary>
        public RadioGroupBox()
        {
            flowLayoutPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false
            };
            Controls.Add(flowLayoutPanel);
        }

        /// <summary>
        /// RadioButtonを追加する。
        /// </summary>
        /// <param name="text"></param>
        /// <param name="tag"></param>
        public void AddItem(string text, object? tag = null)
        {
            var rb = new RadioButton
            {
                Text = text,
                Tag = tag
            };
            rb.CheckedChanged += (s, e) =>
            {
                CheckedChanged?.Invoke(s, e);
            };
            flowLayoutPanel.Controls.Add(rb);
        }
    }
}
