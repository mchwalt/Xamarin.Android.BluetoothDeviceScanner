namespace Bluetooth_Device_Scanner.ListView
{
    public class DataItem : IListItem
    {
        public DataItem(string title, string subtitle, string type, string bluetoothClass)
        {
            Text = title;
            SubTitle = subtitle;
            Type = type;
            BluetoothClass = bluetoothClass;
        }

        public string SubTitle { get; }

        public string Text { get; set; }

        public string Type { get; set; }

        public string BluetoothClass { get; set; }

        public ListItemType GetListItemType()
        {
            return ListItemType.DataItem;
        }

    }
}