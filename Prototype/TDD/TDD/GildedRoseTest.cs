using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace GildedRose
{
	[TestFixture()]
	public class GildedRoseTest
	{
		[Test()]
		public void should_give_item_name_after_adding_item()
		{
			IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
			GildedRose app = new GildedRose(Items);
			Assert.AreEqual("foo", Items[0].Name);
		}
		[Test()]
		public void should_reduce_sellin_by_one_by_day()
		{
			IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 25, Quality = 50 } };
			GildedRose app = new GildedRose(Items);
			app.UpdateQuality();
			Assert.AreEqual(24, Items[0].SellIn);
		}
		[Test()]
		public void should_reduce_quality_by_one_by_day()
		{
			IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 25, Quality = 50 } };
			GildedRose app = new GildedRose(Items);
			app.UpdateQuality();
			Assert.AreEqual(49, Items[0].Quality);
		}
		[Test()]
		public void quality_should_never_be_negative()
		{
			IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
			GildedRose app = new GildedRose(Items);
			app.UpdateQuality();
			Assert.AreEqual(0, Items[0].Quality);
		}
		[Test()]
		public void quality_should_never_be_higher_than_50()
		{
			IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 50 } };
			GildedRose app = new GildedRose(Items);
			app.UpdateQuality();
			Assert.AreEqual(50, Items[0].Quality);
		}
	}
}

