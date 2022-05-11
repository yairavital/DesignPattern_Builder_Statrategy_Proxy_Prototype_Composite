using BuliderDesignPattern;
using System.Text.Json;

HouseBulider iglooHouseBuilder = new IglooHouseBuilder();
iglooHouseBuilder.ConstructHouse();
House igloHouse = iglooHouseBuilder.GetHouse();
Console.WriteLine(igloHouse);
igloHouse.SetRoof("dg");
Console.WriteLine(igloHouse);