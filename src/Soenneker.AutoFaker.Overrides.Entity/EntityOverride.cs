using Soenneker.Utils.AutoBogus.Context;
using Soenneker.Utils.AutoBogus.Override;
using System;

namespace Soenneker.AutoFaker.Overrides.Entity;

/// <summary>
/// An AutoFaker (AutoBogus) override for the object Entity
/// </summary>
public class EntityOverride : AutoFakerOverride<Entities.Entity.Entity>
{
    public override bool CanOverride(AutoFakerContext context)
    {
        return context.GenerateType.IsSubclassOf(typeof(Entities.Entity.Entity));
    }

    public override void Generate(AutoFakerOverrideContext context)
    {
        var target = (context.Instance as Entities.Entity.Entity)!;

        // These can be overriden with more specific type overrides
        target.Id = context.Faker.Random.Guid().ToString();

        DateTimeOffset utcNow = DateTimeOffset.UtcNow;
        target.CreatedAt = utcNow;
        target.ModifiedAt = utcNow;
    }
}