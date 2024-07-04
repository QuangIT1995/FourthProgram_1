internal class Program
{
    private static void Main(string[] args)
    {
        //duyet cac phan tu trong list
        List<string> characterName = new List<string>();
        characterName.Add("Setsuko");
        characterName.Add("Naoko");
        characterName.Add("Akane");
        characterName.Add("Blade");
        characterName.Add("Cobra");
        foreach (var character in characterName)
        {
            Console.WriteLine(character);
        }
        Console.WriteLine("----------------------------");
        foreach (var character in characterName)
        {
            Console.WriteLine(character);
        }
        //trich xuat mot phan tu trong list
        int target = 3;
        string oneOfCharacter = characterName[target];
        Console.WriteLine("----------------------------");
        Console.WriteLine(oneOfCharacter);
        Console.WriteLine("----------------------------");
        //xoa mot phan tu tai vi tri thu 2 trong list
        target = 2;
        characterName.Remove(characterName[target]);
        foreach (var character in characterName)
        {
            Console.WriteLine(character);
        }
        Console.WriteLine("----------------------------");
        //Them mot phan tu
        characterName.Add("Raven");
        Console.WriteLine("----------------------------");
        foreach (var character in characterName)
        {
            Console.WriteLine(character);
        }
        //Kiem tra so phan tu
        Console.WriteLine("----------------------------");
        Console.WriteLine(characterName.Count());
        //Kiem tra ten phan tu co ton tai hay khong
        Console.WriteLine("----------------------------");
        Console.WriteLine(characterName.Contains("Blade"));
        //Xuat ra vi tri cua phan tu trong danh sach
        Console.WriteLine("----------------------------");
        Console.WriteLine(characterName.IndexOf("Naoko"));
        Console.WriteLine("----------------------------");
        //Chen phan tu vao vi tri cua danh sach
        characterName.Insert(3,"Natasha");
        foreach (var character in characterName)
        {
            Console.WriteLine(character);
        }
        Console.WriteLine("----------------------------");
        characterName.Sort();
        foreach (var character in characterName)
        {
            Console.WriteLine(character);
        }
        Console.WriteLine("----------------------------");
        Console.WriteLine(characterName.LastIndexOf("Naoko"));
        Console.WriteLine("----------------------------");
        characterName.Clear();
        Console.WriteLine("List of character: ");
        foreach (var character in characterName)
        {
            Console.WriteLine(character);
        }
        Console.WriteLine("----------------------------");
        List<object> characterAge = new List<object>();
        characterAge.Add("Blade");
        characterAge.Add(30);
        characterAge.Add("Cobra");
        characterAge.Add(26);
        characterAge.Add("Naoko");
        characterAge.Add(28);
        characterAge.Add("Setsuko");
        characterAge.Add(28);
        characterAge.Add("Raven");
        characterAge.Add(28);
        characterAge.Add("Natasha");
        characterAge.Add(30);
        foreach (var character in characterAge)
        {
            Console.WriteLine(character);
        }
    }
}