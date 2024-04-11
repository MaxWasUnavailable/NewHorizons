namespace NewHorizons.Models;

/// <summary>
///     Record representing player data used to migrate between cities.
/// </summary>
public record PlayerMigrationRecord(HumanMigrationRecord HumanPlayerData, int Money, int LockPicks, int SocialCredit)
{
    /// <summary>
    ///     Constructor for creating a new PlayerMigrationRecord.
    /// </summary>
    /// <param name="player"> The player to migrate. </param>
    /// <param name="saveData"> Save data to use for migration. </param>
    public PlayerMigrationRecord(Player player, StateSaveData saveData) : this(new HumanMigrationRecord(player),
        saveData.money, saveData.lockpicks, saveData.socCredit)
    {
    }
}