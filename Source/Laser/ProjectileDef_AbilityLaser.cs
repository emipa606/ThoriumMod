using Verse;

namespace ThoriumLaser;

public class ProjectileDef_AbilityLaser : ThingDef
{
    public bool CanStartFire = false;
    public int HealCapacity = 3;
    public float HealFailChance = 0.3f;
    public bool IsBeamProjectile = false;
    public int postFiringDuration = 0;
    public float postFiringFinalIntensity = 0f;
    public float postFiringInitialIntensity = 0f;
    public int preFiringDuration = 0;
    public float preFiringFinalIntensity = 0f;
    public float preFiringInitialIntensity = 0f;
    public float StartFireChance;
    public string warmupGraphicPathSingle = null;
}