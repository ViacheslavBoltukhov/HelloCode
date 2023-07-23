int Count = 0;
Console.Write("Enter the distance between friends: ");
double Distance = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the speed first friend: ");
int FirstFriendSpeed = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the speed second friend: ");
int SecondFriendSpeed = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the speed dog: ");
int DogSpeed = Convert.ToInt32(Console.ReadLine());
int Friend = 2;
double Time = 1;
while (Distance>10)
{
    if (Friend == 1)
    {
        Time = Distance/(FirstFriendSpeed+DogSpeed);
        Friend = 2;
    }
    if (Friend == 2)
    {
        Time = Distance/(SecondFriendSpeed+DogSpeed);
        Friend = 1;
    }
    Distance = Distance - (FirstFriendSpeed + SecondFriendSpeed)*Time;
    Count++;
}
Console.WriteLine(Distance);
Console.WriteLine(Count);