namespace _03BarracksFactory.Models.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using _03BarracksFactory.Contracts;
    using Attributes;

    class RetireCommand : Command
    {
        [Inject]
        private IRepository repository;

        public RetireCommand(string[] data, IRepository repository) 
            : base(data)
        {
            this.repository = repository;
        }

        public override string Execute()
        {
            string unitType = this.Data[1];

            try
            {
                this.repository.RemoveUnit(unitType);
                return $"{unitType} retired!";
            }
            catch (ArgumentException exception)
            {
                return exception.Message;
            }
        }
    }
}
