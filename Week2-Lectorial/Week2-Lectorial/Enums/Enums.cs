namespace Week2_Lectorial.Enums;

public enum AnimalType
{
    Dog,
    Cat,
    Fish
}

public enum DeliveryStatus
{
    AwaitingCollection = 1,
    Dispatched = 2,
    OnBoardForDelivery = 3,
    Delivered = 4
}

[Flags]
public enum MultiHue : short
{
    None = 0,
    Black = 1,
    Red = 2,
    Green = 4,
    Blue = 8
}
