﻿namespace SRTP_Win
{
    partial class Main_Win
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Log_Win Father_Log_Win;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("张三");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("李四");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("销售人员", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("铜材");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("铁芯");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("化工类");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("绝缘材料");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("产品配件");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("标准件");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("耗材");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("基本材料", new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29});
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("铜材");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("铁芯");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("化工类");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("绝缘材料");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("产品配件");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("标准件");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("耗材");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("基本材料", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("电流一次线圈");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("电流二次线圈");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("电流线圈", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("电压线圈");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("浇筑体");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("压铸体");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("美化体");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("总装体");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("节点18");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("半成品", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("成品");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Win));
            this.Original_Tab = new System.Windows.Forms.TabControl();
            this.Tab_A = new System.Windows.Forms.TabPage();
            this.Tab_B = new System.Windows.Forms.TabPage();
            this.Button_Add_Order = new System.Windows.Forms.Button();
            this.Radio_Order_Run = new System.Windows.Forms.RadioButton();
            this.Radio_Order_Finish = new System.Windows.Forms.RadioButton();
            this.Lable_Order_Manage = new System.Windows.Forms.Label();
            this.OrderDataView = new System.Windows.Forms.DataGridView();
            this.OrderTree = new System.Windows.Forms.TreeView();
            this.Tab_C = new System.Windows.Forms.TabPage();
            this.Button_Add_Purchase_Order = new System.Windows.Forms.Button();
            this.Grid_Purchase_Order = new System.Windows.Forms.DataGridView();
            this.Tree_Purchase_Order = new System.Windows.Forms.TreeView();
            this.Radio_Buy_Order_Run = new System.Windows.Forms.RadioButton();
            this.Radio_Buy_Order_Finished = new System.Windows.Forms.RadioButton();
            this.LabelPurchaseOrder = new System.Windows.Forms.Label();
            this.Tab_D = new System.Windows.Forms.TabPage();
            this.Tab_Produce_Control = new System.Windows.Forms.TabControl();
            this.TabPage_Produce_Control = new System.Windows.Forms.TabPage();
            this.TabPage_Predict = new System.Windows.Forms.TabPage();
            this.Grid_Predict = new System.Windows.Forms.DataGridView();
            this.Label_Predict = new System.Windows.Forms.Label();
            this.Raw_Material_Tab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaterialTree = new System.Windows.Forms.TreeView();
            this.Tab_A_Store = new System.Windows.Forms.TabControl();
            this.Original_Tab.SuspendLayout();
            this.Tab_A.SuspendLayout();
            this.Tab_B.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataView)).BeginInit();
            this.Tab_C.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Purchase_Order)).BeginInit();
            this.Tab_D.SuspendLayout();
            this.Tab_Produce_Control.SuspendLayout();
            this.TabPage_Predict.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Predict)).BeginInit();
            this.Raw_Material_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Tab_A_Store.SuspendLayout();
            this.SuspendLayout();
            // 
            // Original_Tab
            // 
            this.Original_Tab.Controls.Add(this.Tab_A);
            this.Original_Tab.Controls.Add(this.Tab_B);
            this.Original_Tab.Controls.Add(this.Tab_C);
            this.Original_Tab.Controls.Add(this.Tab_D);
            this.Original_Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Original_Tab.Location = new System.Drawing.Point(0, 0);
            this.Original_Tab.Margin = new System.Windows.Forms.Padding(4);
            this.Original_Tab.Name = "Original_Tab";
            this.Original_Tab.SelectedIndex = 0;
            this.Original_Tab.Size = new System.Drawing.Size(1863, 1011);
            this.Original_Tab.TabIndex = 0;
            // 
            // Tab_A
            // 
            this.Tab_A.Controls.Add(this.Tab_A_Store);
            this.Tab_A.Location = new System.Drawing.Point(10, 56);
            this.Tab_A.Margin = new System.Windows.Forms.Padding(4);
            this.Tab_A.Name = "Tab_A";
            this.Tab_A.Padding = new System.Windows.Forms.Padding(4);
            this.Tab_A.Size = new System.Drawing.Size(1843, 945);
            this.Tab_A.TabIndex = 0;
            this.Tab_A.Text = "仓储管理";
            this.Tab_A.UseVisualStyleBackColor = true;
            // 
            // Tab_B
            // 
            this.Tab_B.Controls.Add(this.Button_Add_Order);
            this.Tab_B.Controls.Add(this.Radio_Order_Run);
            this.Tab_B.Controls.Add(this.Radio_Order_Finish);
            this.Tab_B.Controls.Add(this.Lable_Order_Manage);
            this.Tab_B.Controls.Add(this.OrderDataView);
            this.Tab_B.Controls.Add(this.OrderTree);
            this.Tab_B.Location = new System.Drawing.Point(10, 56);
            this.Tab_B.Margin = new System.Windows.Forms.Padding(4);
            this.Tab_B.Name = "Tab_B";
            this.Tab_B.Padding = new System.Windows.Forms.Padding(4);
            this.Tab_B.Size = new System.Drawing.Size(1843, 945);
            this.Tab_B.TabIndex = 1;
            this.Tab_B.Text = "订单管理";
            this.Tab_B.UseVisualStyleBackColor = true;
            // 
            // Button_Add_Order
            // 
            this.Button_Add_Order.Location = new System.Drawing.Point(997, 850);
            this.Button_Add_Order.Name = "Button_Add_Order";
            this.Button_Add_Order.Size = new System.Drawing.Size(222, 58);
            this.Button_Add_Order.TabIndex = 5;
            this.Button_Add_Order.Text = "增加新订单";
            this.Button_Add_Order.UseVisualStyleBackColor = true;
            this.Button_Add_Order.Click += new System.EventHandler(this.Button_Add_Order_Click);
            // 
            // Radio_Order_Run
            // 
            this.Radio_Order_Run.AutoSize = true;
            this.Radio_Order_Run.Location = new System.Drawing.Point(1421, 61);
            this.Radio_Order_Run.Name = "Radio_Order_Run";
            this.Radio_Order_Run.Size = new System.Drawing.Size(204, 43);
            this.Radio_Order_Run.TabIndex = 4;
            this.Radio_Order_Run.Text = "未完成订单";
            this.Radio_Order_Run.UseVisualStyleBackColor = true;
            // 
            // Radio_Order_Finish
            // 
            this.Radio_Order_Finish.AutoSize = true;
            this.Radio_Order_Finish.Checked = true;
            this.Radio_Order_Finish.Location = new System.Drawing.Point(1162, 61);
            this.Radio_Order_Finish.Name = "Radio_Order_Finish";
            this.Radio_Order_Finish.Size = new System.Drawing.Size(204, 43);
            this.Radio_Order_Finish.TabIndex = 3;
            this.Radio_Order_Finish.TabStop = true;
            this.Radio_Order_Finish.Text = "已完成订单";
            this.Radio_Order_Finish.UseVisualStyleBackColor = true;
            this.Radio_Order_Finish.CheckedChanged += new System.EventHandler(this.Radio_Order_Finish_CheckedChanged);
            // 
            // Lable_Order_Manage
            // 
            this.Lable_Order_Manage.AutoSize = true;
            this.Lable_Order_Manage.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lable_Order_Manage.Location = new System.Drawing.Point(793, 32);
            this.Lable_Order_Manage.Name = "Lable_Order_Manage";
            this.Lable_Order_Manage.Size = new System.Drawing.Size(273, 78);
            this.Lable_Order_Manage.TabIndex = 2;
            this.Lable_Order_Manage.Text = "订单管理";
            // 
            // OrderDataView
            // 
            this.OrderDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.OrderDataView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrderDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDataView.Location = new System.Drawing.Point(375, 139);
            this.OrderDataView.Name = "OrderDataView";
            this.OrderDataView.RowHeadersWidth = 102;
            this.OrderDataView.RowTemplate.Height = 44;
            this.OrderDataView.Size = new System.Drawing.Size(1397, 679);
            this.OrderDataView.TabIndex = 1;
            // 
            // OrderTree
            // 
            this.OrderTree.Location = new System.Drawing.Point(39, 139);
            this.OrderTree.Name = "OrderTree";
            treeNode20.Name = "节点1";
            treeNode20.Text = "张三";
            treeNode21.Name = "节点2";
            treeNode21.Text = "李四";
            treeNode22.Name = "节点0";
            treeNode22.Text = "销售人员";
            this.OrderTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode22});
            this.OrderTree.Size = new System.Drawing.Size(273, 769);
            this.OrderTree.TabIndex = 0;
            this.OrderTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.OrderTree_AfterSelect);
            // 
            // Tab_C
            // 
            this.Tab_C.Controls.Add(this.Button_Add_Purchase_Order);
            this.Tab_C.Controls.Add(this.Grid_Purchase_Order);
            this.Tab_C.Controls.Add(this.Tree_Purchase_Order);
            this.Tab_C.Controls.Add(this.Radio_Buy_Order_Run);
            this.Tab_C.Controls.Add(this.Radio_Buy_Order_Finished);
            this.Tab_C.Controls.Add(this.LabelPurchaseOrder);
            this.Tab_C.Location = new System.Drawing.Point(10, 56);
            this.Tab_C.Name = "Tab_C";
            this.Tab_C.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_C.Size = new System.Drawing.Size(1843, 945);
            this.Tab_C.TabIndex = 2;
            this.Tab_C.Text = "采购单管理";
            this.Tab_C.UseVisualStyleBackColor = true;
            // 
            // Button_Add_Purchase_Order
            // 
            this.Button_Add_Purchase_Order.Location = new System.Drawing.Point(997, 850);
            this.Button_Add_Purchase_Order.Name = "Button_Add_Purchase_Order";
            this.Button_Add_Purchase_Order.Size = new System.Drawing.Size(222, 58);
            this.Button_Add_Purchase_Order.TabIndex = 5;
            this.Button_Add_Purchase_Order.Text = "增加新采购单";
            this.Button_Add_Purchase_Order.UseVisualStyleBackColor = true;
            this.Button_Add_Purchase_Order.Click += new System.EventHandler(this.Button_Add_Purchase_Order_Click);
            // 
            // Grid_Purchase_Order
            // 
            this.Grid_Purchase_Order.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Grid_Purchase_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Purchase_Order.Location = new System.Drawing.Point(375, 139);
            this.Grid_Purchase_Order.Name = "Grid_Purchase_Order";
            this.Grid_Purchase_Order.RowHeadersWidth = 102;
            this.Grid_Purchase_Order.RowTemplate.Height = 44;
            this.Grid_Purchase_Order.Size = new System.Drawing.Size(1397, 679);
            this.Grid_Purchase_Order.TabIndex = 4;
            // 
            // Tree_Purchase_Order
            // 
            this.Tree_Purchase_Order.Location = new System.Drawing.Point(39, 139);
            this.Tree_Purchase_Order.Name = "Tree_Purchase_Order";
            treeNode23.Name = "节点1";
            treeNode23.Text = "铜材";
            treeNode24.Name = "节点2";
            treeNode24.Text = "铁芯";
            treeNode25.Name = "节点3";
            treeNode25.Text = "化工类";
            treeNode26.Name = "节点4";
            treeNode26.Text = "绝缘材料";
            treeNode27.Name = "节点5";
            treeNode27.Text = "产品配件";
            treeNode28.Name = "节点6";
            treeNode28.Text = "标准件";
            treeNode29.Name = "节点7";
            treeNode29.Text = "耗材";
            treeNode30.Name = "节点0";
            treeNode30.Text = "基本材料";
            this.Tree_Purchase_Order.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode30});
            this.Tree_Purchase_Order.Size = new System.Drawing.Size(273, 769);
            this.Tree_Purchase_Order.TabIndex = 3;
            this.Tree_Purchase_Order.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Tree_Purchase_Order_AfterSelect);
            // 
            // Radio_Buy_Order_Run
            // 
            this.Radio_Buy_Order_Run.AutoSize = true;
            this.Radio_Buy_Order_Run.Location = new System.Drawing.Point(1464, 63);
            this.Radio_Buy_Order_Run.Name = "Radio_Buy_Order_Run";
            this.Radio_Buy_Order_Run.Size = new System.Drawing.Size(234, 43);
            this.Radio_Buy_Order_Run.TabIndex = 2;
            this.Radio_Buy_Order_Run.Text = "未完成采购单";
            this.Radio_Buy_Order_Run.UseVisualStyleBackColor = true;
            // 
            // Radio_Buy_Order_Finished
            // 
            this.Radio_Buy_Order_Finished.AutoSize = true;
            this.Radio_Buy_Order_Finished.Checked = true;
            this.Radio_Buy_Order_Finished.Location = new System.Drawing.Point(1168, 63);
            this.Radio_Buy_Order_Finished.Name = "Radio_Buy_Order_Finished";
            this.Radio_Buy_Order_Finished.Size = new System.Drawing.Size(234, 43);
            this.Radio_Buy_Order_Finished.TabIndex = 1;
            this.Radio_Buy_Order_Finished.TabStop = true;
            this.Radio_Buy_Order_Finished.Text = "已完成采购单";
            this.Radio_Buy_Order_Finished.UseVisualStyleBackColor = true;
            // 
            // LabelPurchaseOrder
            // 
            this.LabelPurchaseOrder.AutoSize = true;
            this.LabelPurchaseOrder.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelPurchaseOrder.Location = new System.Drawing.Point(742, 34);
            this.LabelPurchaseOrder.Name = "LabelPurchaseOrder";
            this.LabelPurchaseOrder.Size = new System.Drawing.Size(333, 78);
            this.LabelPurchaseOrder.TabIndex = 0;
            this.LabelPurchaseOrder.Text = "采购单管理";
            // 
            // Tab_D
            // 
            this.Tab_D.Controls.Add(this.Tab_Produce_Control);
            this.Tab_D.Location = new System.Drawing.Point(10, 56);
            this.Tab_D.Name = "Tab_D";
            this.Tab_D.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_D.Size = new System.Drawing.Size(1843, 945);
            this.Tab_D.TabIndex = 3;
            this.Tab_D.Text = "生产管理";
            this.Tab_D.UseVisualStyleBackColor = true;
            // 
            // Tab_Produce_Control
            // 
            this.Tab_Produce_Control.Controls.Add(this.TabPage_Produce_Control);
            this.Tab_Produce_Control.Controls.Add(this.TabPage_Predict);
            this.Tab_Produce_Control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab_Produce_Control.Location = new System.Drawing.Point(3, 3);
            this.Tab_Produce_Control.Name = "Tab_Produce_Control";
            this.Tab_Produce_Control.SelectedIndex = 0;
            this.Tab_Produce_Control.Size = new System.Drawing.Size(1837, 939);
            this.Tab_Produce_Control.TabIndex = 0;
            // 
            // TabPage_Produce_Control
            // 
            this.TabPage_Produce_Control.Location = new System.Drawing.Point(10, 56);
            this.TabPage_Produce_Control.Name = "TabPage_Produce_Control";
            this.TabPage_Produce_Control.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Produce_Control.Size = new System.Drawing.Size(1817, 873);
            this.TabPage_Produce_Control.TabIndex = 0;
            this.TabPage_Produce_Control.Text = "产品生产管理";
            this.TabPage_Produce_Control.UseVisualStyleBackColor = true;
            // 
            // TabPage_Predict
            // 
            this.TabPage_Predict.Controls.Add(this.Grid_Predict);
            this.TabPage_Predict.Controls.Add(this.Label_Predict);
            this.TabPage_Predict.Location = new System.Drawing.Point(10, 56);
            this.TabPage_Predict.Name = "TabPage_Predict";
            this.TabPage_Predict.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Predict.Size = new System.Drawing.Size(1817, 873);
            this.TabPage_Predict.TabIndex = 1;
            this.TabPage_Predict.Text = "生产预测";
            this.TabPage_Predict.UseVisualStyleBackColor = true;
            // 
            // Grid_Predict
            // 
            this.Grid_Predict.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_Predict.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Predict.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.Grid_Predict.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Grid_Predict.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Predict.Location = new System.Drawing.Point(83, 130);
            this.Grid_Predict.Name = "Grid_Predict";
            this.Grid_Predict.RowHeadersWidth = 102;
            this.Grid_Predict.RowTemplate.Height = 44;
            this.Grid_Predict.Size = new System.Drawing.Size(1643, 716);
            this.Grid_Predict.TabIndex = 2;
            // 
            // Label_Predict
            // 
            this.Label_Predict.AutoSize = true;
            this.Label_Predict.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Predict.Location = new System.Drawing.Point(742, 34);
            this.Label_Predict.Name = "Label_Predict";
            this.Label_Predict.Size = new System.Drawing.Size(273, 78);
            this.Label_Predict.TabIndex = 0;
            this.Label_Predict.Text = "生产预测";
            // 
            // Raw_Material_Tab
            // 
            this.Raw_Material_Tab.Controls.Add(this.MaterialTree);
            this.Raw_Material_Tab.Controls.Add(this.dataGridView1);
            this.Raw_Material_Tab.Location = new System.Drawing.Point(10, 56);
            this.Raw_Material_Tab.Margin = new System.Windows.Forms.Padding(4);
            this.Raw_Material_Tab.Name = "Raw_Material_Tab";
            this.Raw_Material_Tab.Padding = new System.Windows.Forms.Padding(4);
            this.Raw_Material_Tab.Size = new System.Drawing.Size(1815, 871);
            this.Raw_Material_Tab.TabIndex = 0;
            this.Raw_Material_Tab.Text = "总仓储管理";
            this.Raw_Material_Tab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(291, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 44;
            this.dataGridView1.Size = new System.Drawing.Size(1416, 718);
            this.dataGridView1.TabIndex = 0;
            // 
            // MaterialTree
            // 
            this.MaterialTree.Location = new System.Drawing.Point(23, 76);
            this.MaterialTree.Name = "MaterialTree";
            treeNode1.Name = "节点4";
            treeNode1.Text = "铜材";
            treeNode2.Name = "节点6";
            treeNode2.Text = "铁芯";
            treeNode3.Name = "节点7";
            treeNode3.Text = "化工类";
            treeNode4.Name = "节点8";
            treeNode4.Text = "绝缘材料";
            treeNode5.Name = "节点9";
            treeNode5.Text = "产品配件";
            treeNode6.Name = "节点10";
            treeNode6.Text = "标准件";
            treeNode7.Name = "节点11";
            treeNode7.Text = "耗材";
            treeNode8.Name = "节点2";
            treeNode8.Text = "基本材料";
            treeNode9.Name = "节点19";
            treeNode9.Text = "电流一次线圈";
            treeNode10.Name = "节点20";
            treeNode10.Text = "电流二次线圈";
            treeNode11.Name = "节点12";
            treeNode11.Text = "电流线圈";
            treeNode12.Name = "节点13";
            treeNode12.Text = "电压线圈";
            treeNode13.Name = "节点14";
            treeNode13.Text = "浇筑体";
            treeNode14.Name = "节点15";
            treeNode14.Text = "压铸体";
            treeNode15.Name = "节点16";
            treeNode15.Text = "美化体";
            treeNode16.Name = "节点17";
            treeNode16.Text = "总装体";
            treeNode17.Name = "节点18";
            treeNode17.Text = "节点18";
            treeNode18.Name = "节点3";
            treeNode18.Text = "半成品";
            treeNode19.Name = "节点21";
            treeNode19.Text = "成品";
            this.MaterialTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode18,
            treeNode19});
            this.MaterialTree.Size = new System.Drawing.Size(239, 718);
            this.MaterialTree.TabIndex = 1;
            this.MaterialTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MaterialTree_AfterSelect);
            // 
            // Tab_A_Store
            // 
            this.Tab_A_Store.Controls.Add(this.Raw_Material_Tab);
            this.Tab_A_Store.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab_A_Store.Location = new System.Drawing.Point(4, 4);
            this.Tab_A_Store.Margin = new System.Windows.Forms.Padding(4);
            this.Tab_A_Store.Name = "Tab_A_Store";
            this.Tab_A_Store.SelectedIndex = 0;
            this.Tab_A_Store.Size = new System.Drawing.Size(1835, 937);
            this.Tab_A_Store.TabIndex = 0;
            // 
            // Main_Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1863, 1011);
            this.Controls.Add(this.Original_Tab);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main_Win";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SRTP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Win_FormClosed);
            this.Load += new System.EventHandler(this.Main_Win_Load);
            this.SizeChanged += new System.EventHandler(this.Main_Win_SizeChanged);
            this.Original_Tab.ResumeLayout(false);
            this.Tab_A.ResumeLayout(false);
            this.Tab_B.ResumeLayout(false);
            this.Tab_B.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataView)).EndInit();
            this.Tab_C.ResumeLayout(false);
            this.Tab_C.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Purchase_Order)).EndInit();
            this.Tab_D.ResumeLayout(false);
            this.Tab_Produce_Control.ResumeLayout(false);
            this.TabPage_Predict.ResumeLayout(false);
            this.TabPage_Predict.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Predict)).EndInit();
            this.Raw_Material_Tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Tab_A_Store.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Original_Tab;
        private System.Windows.Forms.TabPage Tab_A;
        private System.Windows.Forms.TabPage Tab_B;
        private System.Windows.Forms.TabPage Tab_C;
        private System.Windows.Forms.TabPage Tab_D;
        private System.Windows.Forms.Label Lable_Order_Manage;
        private System.Windows.Forms.DataGridView OrderDataView;
        private System.Windows.Forms.TreeView OrderTree;
        private System.Windows.Forms.RadioButton Radio_Order_Run;
        private System.Windows.Forms.RadioButton Radio_Order_Finish;
        private System.Windows.Forms.Button Button_Add_Order;
        private System.Windows.Forms.TreeView Tree_Purchase_Order;
        private System.Windows.Forms.RadioButton Radio_Buy_Order_Run;
        private System.Windows.Forms.RadioButton Radio_Buy_Order_Finished;
        private System.Windows.Forms.Label LabelPurchaseOrder;
        private System.Windows.Forms.DataGridView Grid_Purchase_Order;
        private System.Windows.Forms.Button Button_Add_Purchase_Order;
        private System.Windows.Forms.TabControl Tab_Produce_Control;
        private System.Windows.Forms.TabPage TabPage_Produce_Control;
        private System.Windows.Forms.TabPage TabPage_Predict;
        private System.Windows.Forms.DataGridView Grid_Predict;
        private System.Windows.Forms.Label Label_Predict;
        private System.Windows.Forms.TabControl Tab_A_Store;
        private System.Windows.Forms.TabPage Raw_Material_Tab;
        private System.Windows.Forms.TreeView MaterialTree;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}