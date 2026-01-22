using mise_en_application_02_02.classes;

Marchandise m1 = new Marchandise(10.5f, 8.2f);


// Transportation objects
TransportAerien TransportAerien01 = new TransportAerien();
TransportAerienUrgent TransportAerienUrgent01 = new TransportAerienUrgent();
TransportRoutier  TransportRoutier01 = new TransportRoutier();

Console.WriteLine("============ Tarifs Transportation ======");

double tarifTransportationAerien = TransportAerien01.Tarif(m1);
Console.WriteLine($"Tarif Transport Aerien de la  marchandise [ Poids : {m1.Poids} Kg et Volume: {m1.Volume} cm3]: {tarifTransportationAerien} CAD");

Console.WriteLine("+++++++++++++++++++++++++++++++++++++");

double tarifTransportationAerienUrgent = TransportAerienUrgent01.Tarif(m1);
Console.WriteLine($"Tarif Transport Aerien Urgent de la  marchandise [ Poids : {m1.Poids} Kg et Volume: {m1.Volume} cm3]: {tarifTransportationAerienUrgent} CAD");

Console.WriteLine("+++++++++++++++++++++++++++++++++++++");

double tarifTransportationRoutier = TransportRoutier01.Tarif(m1);
Console.WriteLine($"Tarif Transport Routier de la  marchandise [ Poids : {m1.Poids} Kg et Volume: {m1.Volume} cm3]: {tarifTransportationRoutier} CAD");
