using MyFirstApplication;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// The Below Statement calls a local function
// single line comment
HouseExample();

/*
 Multi-line comment
The below statement is a local function. Local functions
are inside of members and are private by default. This means
inside that member.
 */
void HouseExample()
{
    House myHouse = new House();
    myHouse.DoorOpenClose();
}
   
