namespace Bluetooth_Device_Scanner.ListView
{
    public class DataItem : IListItem
    {
        public DataItem(string title, string subtitle, string type, string deviceClass, string majorDeviceClass)
        {
            Text = title;
            SubTitle = subtitle;
            Type = type;
            DeviceClass = deviceClass;
            MajorDeviceClass = majorDeviceClass;
        }

        public string SubTitle { get; }

        public string Text { get; set; }

        public string Type { get; set; }

        public string DeviceClass { get; set; }

        public string MajorDeviceClass { get; set; }

        public ListItemType GetListItemType()
        {
            return ListItemType.DataItem;
        }

    }
}