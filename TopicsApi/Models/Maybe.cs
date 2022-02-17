namespace TopicsApi.Models;


//public record Maybe<T>(bool hasValue, T? value);

//public record Maybe(bool hasValue);

public class Maybe
{
    public Maybe(bool hasValue)
    {
        this.hasValue = hasValue;
    }

    public bool hasValue { get; set; }
}

public class Maybe<T>
{
    public Maybe(bool hasValue, T? value)
    {
        this.hasValue = hasValue;
        this.value = value;
    }

    public bool hasValue { get; set; }
    public T? value { get; set; }
}