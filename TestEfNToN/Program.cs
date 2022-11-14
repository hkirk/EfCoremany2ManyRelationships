// See https://aka.ms/new-console-template for more information

using Microsoft.EntityFrameworkCore;
using TestEfNToN;

Console.WriteLine("Hello, World!");


using (var context = new MyDbContext())
{
    context.Add(new Tag()
    {
        Name = "tag1",
    });
    context.SaveChanges();
}

using (var context = new MyDbContext())
{
    var tag = context.Tags.Single();

    context.Add(new TimeSlot()
    {
        Start = DateTime.Today,
        End = DateTime.Now,
        TagList = new List<Tag>()
        {
            tag
        }
    });

    context.SaveChanges();
}