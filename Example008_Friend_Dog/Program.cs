int count = 0;              // просто счетчик
double distance = 10000;    // Расстояние между друзьями
int firstFriendSpeed = 1;   // Скорость хотьбы первого друга
int secondFriendSpeed = 2;  // Скорость хотьбы второго друга
int dogSpeed = 5;           // Скорость бега собаки
int friend = 2;             // Направление бега собаки
double time = 10;

while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }

    distance = distance - (firstFriendSpeed+secondFriendSpeed)*time;
    count++;
}

Console.WriteLine("Собака от друга к другу пробежала " + count + " раз!");