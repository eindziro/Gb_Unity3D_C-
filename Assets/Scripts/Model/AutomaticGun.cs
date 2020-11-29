namespace Gb_Unity3D_CSharp
{
    /// <summary>
    /// Автоматическое оружие
    /// </summary>
    public sealed class AutomaticGun : Weapon
    {
        public override void Fire()
        {
            if (_isReady) 
                return;
            if (Clip.CountAmmunition <= 0) 
                return;
            var  obj = CacheObjectRepo.Instance.SpawnCachedObject(Ammunition.GetEnumMemberName(),
                _barrel.position, _barrel.rotation,PoolingStratagy.EnqueueManuallyLater);
            var tmpAmmunition = GetComponent<Ammunition>();
            tmpAmmunition.AddForce(_barrel.forward*_force);
            Clip.CountAmmunition--;
            _isReady = false;
            _timeRemaining.AddTimeRemaining();
        }
    }
}