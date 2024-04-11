using System.Collections.Generic;

namespace NewHorizons.Models;

/// <summary>
///     Record representing actor data used to migrate between cities.
/// </summary>
public record ActorMigrationRecord(
    float CurrentHealth,
    float MaximumHealth,
    float RecoveryRate,
    float CombatSkill,
    float MaxNerve,
    List<Interactable> Inventory,
    float StealthSkill)
{
    /// <summary>
    ///     Constructor for ActorMigrationRecord.
    /// </summary>
    /// <param name="actor"> The actor to migrate. </param>
    public ActorMigrationRecord(Actor actor) : this(
        actor.currentHealth,
        actor.maximumHealth,
        actor.recoveryRate,
        actor.combatSkill,
        actor.maxNerve,
        actor.inventory,
        actor.stealthSkill)
    {
    }
}