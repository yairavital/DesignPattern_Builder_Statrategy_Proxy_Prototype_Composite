using ProxyDesginPetternTirgul;
using System.Text.Json;


InteriorOffice interiorOffice = new InteriorOffice();
interiorOffice.SetName("Kandi");
Console.WriteLine( interiorOffice.GetNAme());
IServiceMachine machine = new ServiceMachine(interiorOffice);
machine.RenewalPassport();

