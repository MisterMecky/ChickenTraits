using RimWorld;
using ChickenTraits;
using Verse;
using Verse.AI;

namespace ChickenTraits
{
    public class ThoughtWorker_GermophobeRoomCleanliness : ThoughtWorker
    {
        protected override ThoughtState CurrentStateInternal(Pawn p)
        {
            return ThoughtState.Inactive;
        }
    }
}
