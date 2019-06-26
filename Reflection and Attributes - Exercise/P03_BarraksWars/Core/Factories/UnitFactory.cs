namespace _03BarracksFactory.Core.Factories
{
    using System;
    using System.Reflection;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            Type _unitType = Type.GetType($"_03BarracksFactory.Models.Units.{unitType}");
            var entity = Activator.CreateInstance(_unitType);
            return entity as IUnit; 
        }
    }
}
