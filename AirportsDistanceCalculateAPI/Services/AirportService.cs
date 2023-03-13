using AirportsDistanceCalculateAPI.DTO;
using AirportsDistanceCalculateAPI.Interfaces;
using AirportsDistanceCalculateAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirportsDistanceCalculateAPI.Services
{
    public class AirportService : IAirportService
    {

        //This list represent our database
        public static List<AirportInfo> AirportsList = new List<AirportInfo>()
            {
                new AirportInfo(){CountryCode="TR",RegionName="Ordu",Iata="OGU",Icao="LTCB",Airport="Ordu-Giresun Airport",Latitude=40.966047,Longitude=38.080994},
                new AirportInfo(){CountryCode="TR",RegionName="Adana",Iata="UAB",Icao="LTAG",Airport="Incirlik Air Base",Latitude=37.0021019,Longitude=35.42589951},
                new AirportInfo(){CountryCode="TR",RegionName="Trabzon",Iata="TZX",Icao="LTCG",Airport="Trabzon Airport",Latitude=40.99509811,Longitude=39.78969955},
                new AirportInfo(){CountryCode="TR",RegionName="Amasya",Iata="MZH",Icao="LTAP",Airport="Amasya Merzifon Airport",Latitude=40.829399,Longitude=35.521999},
                new AirportInfo(){CountryCode="TR",RegionName="Bursa",Iata="YEI",Icao="LTBR",Airport="Yenisehir Airport",Latitude=40.25519943,Longitude=29.56259918},
                new AirportInfo(){CountryCode="TR",RegionName="Sanliurfa",Iata="GNY",Icao="LTCS",Airport="Sanliurfa GAP Airport",Latitude=37.445663,Longitude=38.895592},
                new AirportInfo(){CountryCode="TR",RegionName="Elazig",Iata="EZS",Icao="LTCA",Airport="Elazig Airport",Latitude=38.60689926,Longitude=39.29140091},
                new AirportInfo(){CountryCode="TR",RegionName="Isparta",Iata="ISE",Icao="LTFC",Airport="Isparta Suleyman Demirel Airport",Latitude=37.85540009,Longitude=30.36840057},
                new AirportInfo(){CountryCode="TR",RegionName="Sirnak",Iata="NKT",Icao="LTCV",Airport="Sirnak Airport",Latitude=37.3647,Longitude=42.0582},
                new AirportInfo(){CountryCode="TR",RegionName="Hatay",Iata="HTY",Icao="LTDA",Airport="Hatay Airport",Latitude=36.36277771,Longitude=36.28222275},
                new AirportInfo(){CountryCode="TR",RegionName="Istanbul",Iata="ISL",Icao="LTBA",Airport="Istanbul Ataturk Airport",Latitude=40.976898,Longitude=28.8146},
                new AirportInfo(){CountryCode="TR",RegionName="Agri",Iata="AJI",Icao="LTCO",Airport="Agri Airport",Latitude=39.65454102,Longitude=43.02597809},
                new AirportInfo(){CountryCode="TR",RegionName="Tekirdag",Iata="TEQ",Icao="LTBU",Airport="Tekirdag Corlu Airport",Latitude=41.13819885,Longitude=27.91909981},
                new AirportInfo(){CountryCode="TR",RegionName="Sinop",Iata="NOP",Icao="LTCM",Airport="Sinop Airport",Latitude=42.01580048,Longitude=35.06639862},
                new AirportInfo(){CountryCode="TR",RegionName="Bingol",Iata="BGG",Icao="LTCU",Airport="Bingol Airport",Latitude=38.85926056,Longitude=40.59596252},
                new AirportInfo(){CountryCode="TR",RegionName="Kayseri",Iata="ASR",Icao="LTAU",Airport="Erkilet International Airport",Latitude=38.770401,Longitude=35.49539948},
                new AirportInfo(){CountryCode="TR",RegionName="Istanbul",Iata="IST",Icao="LTBA",Airport="Istanbul Ataturk Airport",Latitude=41.275278,Longitude=28.751944},
                new AirportInfo(){CountryCode="TR",RegionName="Balikesir",Iata="EDO",Icao="LTFD",Airport="Balikesir Koca Seyit Airport",Latitude=39.55459976,Longitude=27.01379967},
                new AirportInfo(){CountryCode="TR",RegionName="Kocaeli",Iata="KCO",Icao="LTBQ",Airport="Cengiz Topel Naval Air Station",Latitude=40.73500061,Longitude=30.08329964},
                new AirportInfo(){CountryCode="TR",RegionName="Batman",Iata="BAL",Icao="LTCJ",Airport="Batman Airport",Latitude=37.92900085,Longitude=41.11660004},
                new AirportInfo(){CountryCode="TR",RegionName="Kahramanmaras",Iata="KCM",Icao="LTCN",Airport="Kahramanmaras Airport",Latitude=37.53882599,Longitude=36.95352173},
                new AirportInfo(){CountryCode="TR",RegionName="Canakkale",Iata="CKZ",Icao="LTBH",Airport="Canakkale Airport",Latitude=40.13769913,Longitude=26.42679977},
                new AirportInfo(){CountryCode="TR",RegionName="Hakkari",Iata="YKO",Icao="LTCW",Airport="Hakkari Yuksekova Airport",Latitude=37.5497,Longitude=44.2381},
                new AirportInfo(){CountryCode="TR",RegionName="Gaziantep",Iata="GZT",Icao="LTAJ",Airport="Gaziantep Oguzeli International Airport",Latitude=36.94720078,Longitude=37.47869873},
                new AirportInfo(){CountryCode="TR",RegionName="Antalya",Iata="GZP",Icao="LTFG",Airport="Gazipasa-Alanya Airport",Latitude=36.299217,Longitude=32.300598},
                new AirportInfo(){CountryCode="TR",RegionName="Malatya",Iata="MLX",Icao="LTAT",Airport="Malatya Erhac Airport",Latitude=38.43529892,Longitude=38.0909996},
                new AirportInfo(){CountryCode="TR",RegionName="Aydin",Iata="CII",Icao="LTBD",Airport="Aydin Airport (Cildir Airport)",Latitude=37.81499863,Longitude=27.89529991},
                new AirportInfo(){CountryCode="TR",RegionName="Diyarbakir",Iata="DIY",Icao="LTCC",Airport="Diyarbakir Airport",Latitude=37.89390183,Longitude=40.20100021},
                new AirportInfo(){CountryCode="TR",RegionName="Mugla",Iata="DLM",Icao="LTBS",Airport="Dalaman Airport",Latitude=36.71310043,Longitude=28.79249954},
                new AirportInfo(){CountryCode="TR",RegionName="Mardin",Iata="MQM",Icao="LTCR",Airport="Mardin Airport",Latitude=37.22330093,Longitude=40.63169861},
                new AirportInfo(){CountryCode="TR",RegionName="Denizli",Iata="DNZ",Icao="LTAY",Airport="Denizli Cardak Airport",Latitude=37.78559875,Longitude=29.70129967},
                new AirportInfo(){CountryCode="TR",RegionName="Balikesir",Iata="BZI",Icao="LTBF",Airport="Balikesir Airport (Merkez Airport)",Latitude=39.61930084,Longitude=27.9260006},
                new AirportInfo(){CountryCode="TR",RegionName="Samsun",Iata="SZF",Icao="LTFH",Airport="Samsun-Carsamba Airport",Latitude=41.254501,Longitude=36.567101},
                new AirportInfo(){CountryCode="TR",RegionName="Canakkale",Iata="GKD",Icao="LTFK",Airport="Gokceada Airport",Latitude=40.204498,Longitude=25.883302},
                new AirportInfo(){CountryCode="TR",RegionName="Izmir",Iata="IZM",Icao="",Airport="metropolitan area2",Latitude=33.4376,Longitude=70.6505},
                new AirportInfo(){CountryCode="TR",RegionName="Konya",Iata="KYA",Icao="LTAN",Airport="Konya Airport",Latitude=37.979,Longitude=32.561901},
                new AirportInfo(){CountryCode="TR",RegionName="Mugla",Iata="BXN",Icao="LTBV",Airport="Bodrum-Imsik Airport",Latitude=37.14009857,Longitude=27.66970062},
                new AirportInfo(){CountryCode="TR",RegionName="Mus",Iata="MSR",Icao="LTCK",Airport="Mus Airport",Latitude=38.74779892,Longitude=41.66120148},
                new AirportInfo(){CountryCode="TR",RegionName="Kutahya",Iata="KZR",Icao="LTBZ",Airport="Zafer Airport",Latitude=39.113079,Longitude=30.128111},
                new AirportInfo(){CountryCode="TR",RegionName="Istanbul",Iata="SAW",Icao="LTFJ",Airport="Sabiha Gokcen International Airport",Latitude=40.89860153,Longitude=29.30920029},
                new AirportInfo(){CountryCode="TR",RegionName="Igdir",Iata="IGD",Icao="LTCT",Airport="Igdir Airport",Latitude=39.97662735,Longitude=43.87664795},
                new AirportInfo(){CountryCode="TR",RegionName="Kastamonu",Iata="KFS",Icao="LTAL",Airport="Kastamonu Airport",Latitude=41.31420135,Longitude=33.79579926},
                new AirportInfo(){CountryCode="TR",RegionName="Izmir",Iata="IGL",Icao="LTBL",Airport="Cigli Air Base",Latitude=38.51300049,Longitude=27.01009941},
                new AirportInfo(){CountryCode="TR",RegionName="Mugla",Iata="BJV",Icao="LTFE",Airport="Milas-Bodrum Airport",Latitude=37.25059891,Longitude=27.66430092},
                new AirportInfo(){CountryCode="TR",RegionName="Siirt",Iata="SXZ",Icao="LTCL",Airport="Siirt Airport",Latitude=37.97890091,Longitude=41.8404007},
                new AirportInfo(){CountryCode="TR",RegionName="Afyonkarahisar",Iata="AFY",Icao="LTAH",Airport="Afyon Airport",Latitude=38.72639847,Longitude=30.60110092},
                new AirportInfo(){CountryCode="TR",RegionName="Tokat",Iata="TJK",Icao="LTAW",Airport="Tokat Airport",Latitude=40.30743027,Longitude=36.36740875},
                new AirportInfo(){CountryCode="TR",RegionName="Usak",Iata="USQ",Icao="LTBO",Airport="Usak Airport",Latitude=38.68149948,Longitude=29.47170067},
                new AirportInfo(){CountryCode="TR",RegionName="Nevsehir",Iata="NAV",Icao="LTAZ",Airport="Nevsehir Kapadokya Airport",Latitude=38.7719,Longitude=34.5345},
                new AirportInfo(){CountryCode="TR",RegionName="Sanliurfa",Iata="SFQ",Icao="LTCH",Airport="Sanliurfa Airport",Latitude=37.09429932,Longitude=38.8470993},
                new AirportInfo(){CountryCode="TR",RegionName="Ankara",Iata="ANK",Icao="LTAD",Airport="Etimesgut Air Base",Latitude=39.94979858,Longitude=32.68859863},
                new AirportInfo(){CountryCode="TR",RegionName="Erzincan",Iata="ERC",Icao="LTCD",Airport="Erzincan Airport",Latitude=39.71020126,Longitude=39.52700043},
                new AirportInfo(){CountryCode="TR",RegionName="Antalya",Iata="AYT",Icao="LTAI",Airport="Antalya Airport",Latitude=36.898701,Longitude=30.800501},
                new AirportInfo(){CountryCode="TR",RegionName="Van",Iata="VAN",Icao="LTCI",Airport="Van Ferit Melen Airport",Latitude=38.46820068,Longitude=43.33229828},
                new AirportInfo(){CountryCode="TR",RegionName="Adiyaman",Iata="ADF",Icao="LTCP",Airport="Adiyaman Airport",Latitude=37.73139954,Longitude=38.46889877},
                new AirportInfo(){CountryCode="TR",RegionName="Izmir",Iata="ADB",Icao="LTBJ",Airport="Adnan Menderes Airport",Latitude=38.29240036,Longitude=27.15699959},
                new AirportInfo(){CountryCode="TR",RegionName="Adana",Iata="ADA",Icao="LTAF",Airport="Adana Sakirpasa Airport",Latitude=36.98220062,Longitude=35.28039932},
                new AirportInfo(){CountryCode="TR",RegionName="Kars",Iata="KSY",Icao="LTCF",Airport="Kars Harakani Airport",Latitude=40.56219864,Longitude=43.11500168},
                new AirportInfo(){CountryCode="TR",RegionName="Sivas",Iata="VAS",Icao="LTAR",Airport="Sivas Airport",Latitude=39.813801,Longitude=36.9035},
                new AirportInfo(){CountryCode="TR",RegionName="Balikesir",Iata="BDM",Icao="LTBG",Airport="Bandirma Airport",Latitude=40.31800079,Longitude=27.97769928},
                new AirportInfo(){CountryCode="TR",RegionName="Eskisehir",Iata="AOE",Icao="LTBY",Airport="Anadolu Airport",Latitude=39.809898,Longitude=30.5194},
                new AirportInfo(){CountryCode="TR",RegionName="Zonguldak",Iata="ONQ",Icao="LTAS",Airport="Zonguldak Airport",Latitude=41.50640106,Longitude=32.08860016},
                new AirportInfo(){CountryCode="TR",RegionName="Erzincan",Iata="ERZ",Icao="LTCE",Airport="Erzurum Airport",Latitude=39.95650101,Longitude=41.17020035},
                new AirportInfo(){CountryCode="TR",RegionName="Ankara",Iata="ESB",Icao="LTAC",Airport="Esenboga International Airport",Latitude=40.12810135,Longitude=32.99509811},
                new AirportInfo(){CountryCode="TR",RegionName="Eskisehir",Iata="ESK",Icao="LTBI",Airport="Eskisehir Airport",Latitude=39.78409958,Longitude=30.58209991}
            };

        public async Task<ReturnType> CalculateDistance(string Iata1, string Iata2)
        {
            ReturnType result = new ReturnType();

            result.Airport1 = await GetAirport(Iata1);
            result.Airport2 = await GetAirport(Iata2);

            result.DistanceBetweenAirportsAsMile =await CalculateDistanceBetweenPlaces(result.Airport1.Latitude, result.Airport1.Longitude, result.Airport2.Latitude, result.Airport2.Longitude);

            return  result;
        }

        public async Task<AirportInfo> GetAirport(string Iata)
        {
            var Airport = AirportsList.Where(x => x.Iata == Iata).FirstOrDefault();

            return Airport;
        }

        public Task<double> CalculateDistanceBetweenPlaces(double lat1, double lon1, double lat2, double lon2)
        {
            const double earthRadiusMiles = 3959; // dünya yarıçapı, mil cinsinden

            // Koordinatları radyan cinsinden hesapla
            double lat1Rad = ToRadians(lat1);
            double lon1Rad = ToRadians(lon1);
            double lat2Rad = ToRadians(lat2);
            double lon2Rad = ToRadians(lon2);

            // Delta (fark) hesapla
            double deltaLat = lat2Rad - lat1Rad;
            double deltaLon = lon2Rad - lon1Rad;

            // Haversine formülü kullanarak mesafeyi hesapla
            double a = Math.Pow(Math.Sin(deltaLat / 2), 2) +
                       Math.Cos(lat1Rad) * Math.Cos(lat2Rad) *
                       Math.Pow(Math.Sin(deltaLon / 2), 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double distance = earthRadiusMiles * c;

            return Task.FromResult(distance);
        }

        static double ToRadians(double angle)
        {
            return Math.PI * angle / 180.0;
        }

    }
}
