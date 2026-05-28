using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        /// 入力したGroupBoxのサイズや配置などを引き継いでCheckGroupBoxを作成する。
        /// </summary>
        /// <param name="original"></param>
        public CheckGroupBox(GroupBox original)
        {
            // 元の親を取得
            var parent = original.Parent;

            // 元の位置・サイズ・Dock・Anchor・Text をコピー
            this.Location = original.Location;
            this.Size = original.Size;
            this.Dock = original.Dock;
            this.Anchor = original.Anchor;
            this.Text = original.Text;

            // 親の Controls 内での順番を保持
            int index = parent.Controls.GetChildIndex(original);

            // 元の GroupBox を親から削除
            parent.Controls.Remove(original);

            // 自分（CheckGroupBox）を同じ位置に挿入
            parent.Controls.Add(this);
            parent.Controls.SetChildIndex(this, index);

            // 内部パネルの初期化（縦に伸びる設定）
            PanelInitialize();

            // 右クリックメニューなどの初期化もここで可能
            // InitializeContextMenu();
        }


        /// <summary>
        /// FlowLayoutPanelを初期化してGroupBoxに追加する。
        /// </summary>
        private void PanelInitialize()
        {
            
            panel.MinimumSize = new Size(this.Width, 50);
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

        public void DeleteItem(int index)
        {
            if (index < 0 || index >= checkBoxes.Count)
                return;

            var cb = checkBoxes[index];

            // イベント解除（必要なら）
            cb.CheckedChanged -= CheckedChanged;

            // UI から削除
            panel.Controls.Remove(cb);

            // 論理リストから削除
            checkBoxes.RemoveAt(index);

            // レイアウト更新（必要なら）
            panel.PerformLayout();
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
