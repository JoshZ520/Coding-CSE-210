class person {
    string first_name;

    string last_name;

    string hair_color;

    public person(string f, string l, string h) {
        first_name = f;
        last_name = l;
        hair_color = h;
    }

    public void greeting() {
        Console.WriteLine($"Hello my name is {first_name}, my hair color is {hair_color}");
    }
}