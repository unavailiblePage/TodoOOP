namespace TodoOOP;

public class Menu
{
    public int ShowMenuSelection()
    {
        Console.WriteLine("______MENU______");
        Console.WriteLine("1) SHOW TODOS");
        Console.WriteLine("2) ADD TODO");
        Console.WriteLine("3) EDIT TODO");
        Console.WriteLine("4) DELETE TODO");
        Console.WriteLine("5) SAVE & EXIT");

        Console.WriteLine("Choose what you want to do: ");
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Add valid choice!");
        }

        switch (choice)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
        }

        return choice;
    }
}