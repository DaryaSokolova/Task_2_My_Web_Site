using System;
using System.Collections.Generic;

namespace NewSite24.EF
{
    public class MyDbContext
    {
        public List<Station> Stations;
        public List<Direction> Directions;

        public MyDbContext()
        {
            Directions = new List<Direction>
            {
                new Direction { Name = "Савелевское", Path = "Savelevskoe"},
                new Direction { Name = "Киевское", Path = "Kievskoe"},
                new Direction { Name = "Белорусское", Path = "Belorusskoe"},
            };

            //Stations = new List<Station>
            //{
            //    new Station {
            //        Id = 1,
            //        Name = "Тимирязевская",
            //        Distance = 3.0 + " км",
            //        Direction = 0,
            //        Path = "timiryazevskaya"},

            //    new Station {
            //        Id = 2,
            //        Name = "Окружная",
            //        Distance = 6.4 + " км",
            //        Direction = 0,
            //        Path = "okrygnaya"},

            //    new Station {
            //        Id = 3,
            //        Name = "Дегунино",
            //        Distance = 8.3 + " км",
            //        Direction = 0,
            //        Path = "degunino"},

            //    new Station {
            //        Id = 4,
            //        Name = "Бескудниково",
            //        Distance = 10.3 + " км",
            //        Direction = 0,
            //        Path = "beskudnikovo"},

            //    new Station {
            //        Id = 5,
            //        Name = "Матвеевское",
            //        Distance = 7.2 + " км",
            //        Direction = 1,
            //        Path = "matveevskoe"},

            //    new Station {
            //        Id = 6,
            //        Name = "Очаково",
            //        Distance = 10.6 + " км",
            //        Direction = 1,
            //        Path = "ochakovo"},

            //    new Station {
            //        Id = 7,
            //        Name = "Мещерская",
            //        Distance = 12.8 + " км",
            //        Direction = 1,
            //        Path = "mezjerskoe"},

            //    new Station {
            //        Id = 8,
            //        Name = "Солнечная",
            //        Distance = 15.7 + " км",
            //        Direction = 1,
            //        Path = "solnechnaya"},

            //    new Station {
            //        Id = 9,
            //        Name = "Беговая",
            //        Distance = 2.0 + " км",
            //        Direction = 2,
            //        Path = "begovaya",
            //    Text = "Бегова́я — остановочный пункт Смоленского (Белорусского) " +
            //    "направления Московской железной дороги в Москве, станция линии МЦД-1 " +
            //    "«Белорусско-Савёловский» Московских центральных диаметров." +
            //    "Расположен возле Ваганьковского путепровода, развязки Третьего " +
            //    "транспортного кольца и Хорошёвского шоссе. Вблизи находятся " +
            //    "Ваганьковское кладбище и Московский ипподром " +
            //    "(от которого и пошло название местности «Бега», давшее название " +
            //    "железнодорожной платформе).  Состоит из двух боковых платформ, " +
            //    "соединённых подземным переходом. " +
            //    "Северная платформа — № 1, от Москвы, располагается " +
            //    "ближе ко входу в метро, южная платформа — № 2, " +
            //    "на Москву. В 2000 году обе платформы были оборудованы турникетами.",
            //    Views = 4793,
            //    Comments = 53 },

            //    new Station {
            //        Id = 10,
            //        Name = "Фили",
            //        Distance = 6.2 + " км",
            //        Direction = 2,
            //        Path = "fili"}
            //};
        }
    }
}
