using GildedRose.Console;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using System.Collections.Generic;

namespace GildedRose.Test
{
    

    
    public class InventoryTests
    {
        [Test]
        public void TestDexterityVestQuality()
        {
            var app = new GildedRose.Console.Program()
            {
                Items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20}
            }
            };

            app.UpdateQuality();
            Assert.AreEqual(9, app.Items[0].SellIn);
            Assert.AreEqual(19, app.Items[0].Quality);
        }

        [Test]
        public void TestAgedBrieQuality()
        {
            var app = new GildedRose.Console.Program()
            {
                Items = new List<Item>
            {
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0}
            }
            };

            app.UpdateQuality();
            Assert.AreEqual(1, app.Items[0].SellIn);
            Assert.AreEqual(1, app.Items[0].Quality);
        }

        [Test]
        public void TestElixirOfTheMongooseQuality()
        {
            var app = new GildedRose.Console.Program()
            {
                Items = new List<Item>
            {
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7}
            }
            };

            app.UpdateQuality();
            Assert.AreEqual(4, app.Items[0].SellIn);
            Assert.AreEqual(6, app.Items[0].Quality);
        }

        [Test]
        public void TestSulfurasQuality()
        {
            var app = new GildedRose.Console.Program()
            {
                Items = new List<Item>
            {
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80}
            }
            };

            app.UpdateQuality();
            Assert.AreEqual(0, app.Items[0].SellIn);
            Assert.AreEqual(80, app.Items[0].Quality);
        }

        [Test]
        public void TestBackstagePassesQuality()
        {
            var app = new GildedRose.Console.Program()
            {
                Items = new List<Item>
            {
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                }
            }
            };

            app.UpdateQuality();
            Assert.AreEqual(14, app.Items[0].SellIn);
            Assert.AreEqual(21, app.Items[0].Quality);
        }

        [Test]
        public void TestConjuredManaCakeQuality()
        {
            var app = new GildedRose.Console.Program()
            {
                Items = new List<Item>
            {
                new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            }
            };

            app.UpdateQuality();
            Assert.AreEqual(2, app.Items[0].SellIn);
            Assert.AreEqual(5, app.Items[0].Quality); // Note: The code doesn't have specific rules for "Conjured" items, so this test assumes normal item behavior.
        }
    }
    

}