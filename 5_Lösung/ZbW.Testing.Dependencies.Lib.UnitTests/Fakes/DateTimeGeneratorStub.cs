﻿namespace ZbW.Testing.Dependencies.Lib.UnitTests.Fakes
{
    using System;

    public class DateTimeGeneratorStub : IDateTimeGenerator
    {
        private readonly DateTime _currentDateTime;

        public DateTimeGeneratorStub(DateTime currentDateTime)
        {
            _currentDateTime = currentDateTime;
        }

        public DateTime CurrentDateTime()
        {
            return _currentDateTime;
        }
    }
}