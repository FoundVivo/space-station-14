﻿using Robust.Shared.GameObjects;

namespace Content.Shared.GameObjects.Components.Mobs.State
{
    public abstract class SharedDeadMobState : BaseMobState
    {
        protected override DamageState DamageState => DamageState.Dead;

        public override void EnterState(IEntity entity)
        {
            base.EnterState(entity);
            var wake = entity.EnsureComponent<CollisionWakeComponent>();
            wake.Enabled = true;
        }

        public override void ExitState(IEntity entity)
        {
            base.ExitState(entity);
            if (entity.HasComponent<CollisionWakeComponent>())
            {
                entity.RemoveComponent<CollisionWakeComponent>();
            }
        }

        public override bool CanInteract()
        {
            return false;
        }

        public override bool CanMove()
        {
            return false;
        }

        public override bool CanUse()
        {
            return false;
        }

        public override bool CanThrow()
        {
            return false;
        }

        public override bool CanSpeak()
        {
            return false;
        }

        public override bool CanDrop()
        {
            return false;
        }

        public override bool CanPickup()
        {
            return false;
        }

        public override bool CanEmote()
        {
            return false;
        }

        public override bool CanAttack()
        {
            return false;
        }

        public override bool CanEquip()
        {
            return false;
        }

        public override bool CanUnequip()
        {
            return false;
        }

        public override bool CanChangeDirection()
        {
            return false;
        }

        public bool CanShiver()
        {
            return false;
        }

        public bool CanSweat()
        {
            return false;
        }
    }
}
