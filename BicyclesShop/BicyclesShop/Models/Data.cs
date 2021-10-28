using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicyclesShop.Models
{
    public class Data
    {
        public static void Init(BicycleContext context)
        {
            if (!context.Bicycles.Any())
            {
                context.Bicycles.AddRange(
                    new Bicycle
                    {
                        Title = "Toprider MTB Profi 2020",
                        Color = "Зеленый",
                        Type = "Горный МТВ",
                        WheelDiametr = 24,
                        FrameSize = 14,
                        FrameMaterial = "Алюминий",
                        Price = 4900
                    },
                    new Bicycle
                    {
                        Title = "Kinetic STORM 2021",
                        Color = "Синий",
                        Type = "Спортивный",
                        WheelDiametr = 29,
                        FrameSize = 18,
                        FrameMaterial = "Алюминий",
                        Price = 8758
                    },
                    new Bicycle
                    {
                        Title = "RIDER DD 2021",
                        Color = "Серый",
                        Type = "Хардтейл",
                        WheelDiametr = 29,
                        FrameSize = 21,
                        FrameMaterial = "Сталь",
                        Price = 5123
                    },
                    new Bicycle
                    {
                        Title = "Oskar Lady 2020",
                        Color = "Желтый",
                        Type = "Горный",
                        WheelDiametr = 26,
                        FrameSize = 19,
                        FrameMaterial = "Сталь",
                        Price = 6000
                    },
                    new Bicycle
                    {
                        Title = "Orbea 27 MX40 21",
                        Color = "Синий",
                        Type = "Хардтейл",
                        WheelDiametr = 27,
                        FrameSize = 20,
                        FrameMaterial = "Алюминий",
                        Price = 23072
                    },
                    new Bicycle
                    {
                        Title = "SPARK RANGER 27,5 2021",
                        Color = "Зеленый",
                        Type = "Туристические (гибрид)",
                        WheelDiametr = 27,
                        FrameSize = 17,
                        FrameMaterial = "Сталь",
                        Price = 4199
                    },
                    new Bicycle
                    {
                        Title = "Leon HD-80 2021",
                        Color = "Зеленый",
                        Type = "Туристические (гибрид)",
                        WheelDiametr = 28,
                        FrameSize = 19,
                        FrameMaterial = "Алюминий",
                        Price = 13087
                    },
                    new Bicycle
                    {
                        Title = "Kinetic STORM 2021",
                        Color = "Черный",
                        Type = "Спортивный",
                        WheelDiametr = 29,
                        FrameSize = 18,
                        FrameMaterial = "Сталь",
                        Price = 8758
                    },
                    new Bicycle
                    {
                        Title = "Kelb E-1911WS 26″ 350W, 48V",
                        Color = "Зеленый",
                        Type = "Электровелосипед",
                        WheelDiametr = 26,
                        FrameSize = 22,
                        FrameMaterial = "Алюминий",
                        Price = 25575
                    },
                    new Bicycle
                    {
                        Title = "Cross Grizzly 27,5 2021",
                        Color = "Синий",
                        Type = "Горный",
                        WheelDiametr = 27,
                        FrameSize = 20,
                        FrameMaterial = "Сталь",
                        Price = 10140
                    },
                    new Bicycle
                    {
                        Title = "Toprider",
                        Color = "Зеленый",
                        Type = "Горный",
                        WheelDiametr = 24,
                        FrameSize = 14,
                        FrameMaterial = "Алюминий",
                        Price = 4900
                    },
                    new Bicycle
                    {
                        Title = "Winora Domingo men 28″ 27-G Deore 2021",
                        Color = "Белый",
                        Type = "Туристические (гибрид)",
                        WheelDiametr = 31,
                        FrameSize = 22,
                        FrameMaterial = "Сталь",
                        Price = 18200
                    },
                    new Bicycle
                    {
                        Title = "Cronus Warrior 2020",
                        Color = "Черный",
                        Type = "Спортивный",
                        WheelDiametr = 29,
                        FrameSize = 21,
                        FrameMaterial = "Алюминий",
                        Price = 11115
                    },
                    new Bicycle
                    {
                        Title = "Liv 28 BeLiv 2 City 2021",
                        Color = "Синий",
                        Type = "Туристические (гибрид)",
                        WheelDiametr = 28,
                        FrameSize = 16,
                        FrameMaterial = "Сталь",
                        Price = 27000
                    },
                    new Bicycle
                    {
                        Title = "KELBBIKE MTB 26 2021",
                        Color = "Серый",
                        Type = "Электровелосипед",
                        WheelDiametr = 26,
                        FrameSize = 13,
                        FrameMaterial = "Алюминий",
                        Price = 16500
                    },
                    new Bicycle
                    {
                        Title = "Toprider",
                        Color = "Белый",
                        Type = "Горный",
                        WheelDiametr = 24,
                        FrameSize = 14,
                        FrameMaterial = "Алюминий",
                        Price = 4900
                    },
                    new Bicycle
                    {
                        Title = "Kinetic STORM 2021",
                        Color = "Красный",
                        Type = "Спортивный",
                        WheelDiametr = 29,
                        FrameSize = 18,
                        FrameMaterial = "Сталь",
                        Price = 8758
                    },
                    new Bicycle
                    {
                        Title = "Liv 28 BeLiv 2 City 2021",
                        Color = "Зеленый",
                        Type = "Туристические (гибрид)",
                        WheelDiametr = 28,
                        FrameSize = 16,
                        FrameMaterial = "Алюминий",
                        Price = 27000
                    },
                    new Bicycle
                    {
                        Title = "Toprider",
                        Color = "Белый",
                        Type = "Горный",
                        WheelDiametr = 24,
                        FrameSize = 12,
                        FrameMaterial = "Сталь",
                        Price = 4900
                    },
                    new Bicycle
                    {
                        Title = "Orbea 29 WILD FS H25 LG 2021",
                        Color = "Красный",
                        Type = "Электровелосипед",
                        WheelDiametr = 29,
                        FrameSize = 13,
                        FrameMaterial = "Сталь",
                        Price = 184884
                    },
                    new Bicycle
                    {
                        Title = "Toprider",
                        Color = "Желтый",
                        Type = "Горный",
                        WheelDiametr = 24,
                        FrameSize = 14,
                        FrameMaterial = "Алюминий",
                        Price = 4900
                    },
                    new Bicycle
                    {
                        Title = "Cronus Warrior 2020",
                        Color = "Белый",
                        Type = "Спортивный",
                        WheelDiametr = 29,
                        FrameSize = 21,
                        FrameMaterial = "Алюминий",
                        Price = 11115
                    },
                    new Bicycle
                    {
                        Title = "Cross Grizzly 27,5 2021",
                        Color = "Зеленый",
                        Type = "Горный",
                        WheelDiametr = 27,
                        FrameSize = 20,
                        FrameMaterial = "Сталь",
                        Price = 10140
                    },
                    new Bicycle
                    {
                        Title = "Kinetic STORM 2021",
                        Color = "Зеленый",
                        Type = "Спортивный",
                        WheelDiametr = 29,
                        FrameSize = 18,
                        FrameMaterial = "Алюминий",
                        Price = 8758
                    },
                    new Bicycle
                    {
                        Title = "Vento Monte 2021",
                        Color = "Серый",
                        Type = "Спортивный",
                        WheelDiametr = 29,
                        FrameSize = 21,
                        FrameMaterial = "Сталь",
                        Price = 12999
                    },
                    new Bicycle
                    {
                        Title = "Cronus Warrior 2020",
                        Color = "Серый",
                        Type = "Спортивный",
                        WheelDiametr = 29,
                        FrameSize = 21,
                        FrameMaterial = "Сталь",
                        Price = 11115
                    },
                    new Bicycle
                    {
                        Title = "KELBBIKE MTB 26 2021",
                        Color = "Зеленый",
                        Type = "Электровелосипед",
                        WheelDiametr = 26,
                        FrameSize = 13,
                        FrameMaterial = "Алюминий",
                        Price = 16500
                    },
                    new Bicycle
                    {
                        Title = "Toprider",
                        Color = "Черный",
                        Type = "Горный",
                        WheelDiametr = 24,
                        FrameSize = 14,
                        FrameMaterial = "Сталь",
                        Price = 4900
                    },
                    new Bicycle
                    {
                        Title = "Orbea 29 WILD FS H25 LG 2021",
                        Color = "Серый",
                        Type = "Электровелосипед",
                        WheelDiametr = 29,
                        FrameSize = 13,
                        FrameMaterial = "Алюминий",
                        Price = 184884
                    },
                    new Bicycle
                    {
                        Title = "Vento Monte 2021",
                        Color = "Красный",
                        Type = "Спортивный",
                        WheelDiametr = 29,
                        FrameSize = 21,
                        FrameMaterial = "Сталь",
                        Price = 12999
                    }

                    );
                context.SaveChanges();
            }
        }
    }
}
