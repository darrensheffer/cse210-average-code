public abstract class Event
{
    protected string _type;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = new(address);
    }

    public string GetShortDetails()
    {
        return $"{_type} - {_title} - {_date}";
    }

    public string GetBaseDetails()
    {
        string addressString = _address.GetAddressString();
        return $"{_title} - {_description}\n{_date} @ {_time}\n{addressString}";
    }

    public abstract string GetFullDetails();
}