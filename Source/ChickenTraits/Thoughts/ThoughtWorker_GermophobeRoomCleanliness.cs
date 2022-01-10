using RimWorld;
using Verse;
using Verse.AI;

namespace ChickenTraits
{
    public class ThoughtWorker_GermophobeRoomCleanliness : ThoughtWorker
    {
        protected override ThoughtState CurrentStateInternal(Pawn p)
        {
            Room room = p.GetRoom(RegionType.Set_All);
            //Log.Message("Bop");
            if (room==null)
            {
                return ThoughtState.Inactive;
            }
            int scoreStageIndex = RoomStatDefOf.Cleanliness.GetScoreStageIndex(room.GetStat(RoomStatDefOf.Cleanliness));
            if (this.def.stages[scoreStageIndex] == null)
            {
                return ThoughtState.Inactive;
            }
            return ThoughtState.ActiveAtStage(scoreStageIndex);
        }
    }
}
