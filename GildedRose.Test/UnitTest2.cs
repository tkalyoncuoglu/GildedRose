using GildedRose.Console;
using NUnit.Framework;
using System.Collections.Generic;

namespace GildedRose.Tests
{
    public class GildedRoseTests
    {
        private Program _app;

        [SetUp]
        public void Setup()
        {
            _app = new Program
            {
                Items = new List<Item>
                {
                    new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                    new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                    new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                    new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                    new Item
                    {
                        Name = "Backstage passes to a TAFKAL80ETC concert",
                        SellIn = 15,
                        Quality = 20
                    },
                    new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                }
            };
        }

        private void RunUpdateQuality(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _app.UpdateQuality();
            }
        }

        [Test]
        public void TestDexterityVestAfterFiveDays()
        {
            RunUpdateQuality(5);
            Assert.AreEqual(5, _app.Items[0].SellIn);
            Assert.AreEqual(15, _app.Items[0].Quality);
        }

        [Test]
        public void TestAgedBrieAfterFiveDays()
        {
            RunUpdateQuality(5);
            Assert.AreEqual(-3, _app.Items[1].SellIn);
            Assert.AreEqual(8, _app.Items[1].Quality);
        }

        [Test]
        public void TestElixirOfTheMongooseAfterFiveDays()
        {
            RunUpdateQuality(5);
            Assert.AreEqual(0, _app.Items[2].SellIn);
            Assert.AreEqual(2, _app.Items[2].Quality);
        }

        [Test]
        public void TestSulfurasAfterFiveDays()
        {
            RunUpdateQuality(5);
            Assert.AreEqual(0, _app.Items[3].SellIn);
            Assert.AreEqual(80, _app.Items[3].Quality);
        }

        [Test]
        public void TestBackstagePassesAfterFiveDays()
        {
            RunUpdateQuality(5);
            Assert.AreEqual(10, _app.Items[4].SellIn);
            Assert.AreEqual(25, _app.Items[4].Quality);
        }

        [Test]
        public void TestConjuredManaCakeAfterFiveDays()
        {
            RunUpdateQuality(5);
            Assert.AreEqual(-2, _app.Items[5].SellIn);
            Assert.AreEqual(0, _app.Items[5].Quality);
        }
    }
}

