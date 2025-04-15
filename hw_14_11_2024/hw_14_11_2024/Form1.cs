namespace hw_14_11_2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeWishList();
        }

        private void InitializeWishList()
        {
            ListView listView1 = new ListView
            {
                View = View.Details,
                CheckBoxes = true,
                FullRowSelect = true,
                GridLines = true,
                Dock = DockStyle.Fill
            };

            listView1.Columns.Add(" ", 40);
            listView1.Columns.Add("Иконка", 70);
            listView1.Columns.Add("Название товара", 150);
            listView1.Columns.Add("Цена (грн)", 100);

            string[] items = { "Постетить США", "Найти работу по специальности (Dev.)", "Книга \"Наедине с собой\" Марк Аврелий ", "Перезапустить e-commerce проект", "Полететь на море)" };
            int[] prices = { 43000, 0, 299, 122325, 35000 };
            ImageList imageList = new ImageList();

            imageList.Images.Add(Bitmap.FromFile(@"D:\iconshw\USA.png"));
            imageList.Images.Add(Bitmap.FromFile(@"D:\iconshw\dev.png"));
            imageList.Images.Add(Bitmap.FromFile(@"D:\iconshw\book.jpg"));
            imageList.Images.Add(Bitmap.FromFile(@"D:\iconshw\e-com.png"));
            imageList.Images.Add(Bitmap.FromFile(@"D:\iconshw\sea.png"));

            listView1.SmallImageList = imageList;

            for (int i = 0; i < items.Length; i++)
            {
                ListViewItem listItem = new ListViewItem();
                listItem.SubItems.Add("");
                listItem.SubItems.Add(items[i]);
                listItem.SubItems.Add(prices[i].ToString() + " грн");
                listItem.ImageIndex = i;

                listView1.Items.Add(listItem);
            }
            this.Controls.Add(listView1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
