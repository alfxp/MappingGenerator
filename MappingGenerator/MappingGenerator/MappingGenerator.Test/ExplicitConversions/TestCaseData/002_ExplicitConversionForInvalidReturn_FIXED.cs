﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MappingGenerator.Test.ExplicitConversions.TestCaseData
{
    public class TestMapper
    {
        public AddressDTO Address { get; set; }

        public ReadOnlyCollection<AddressDTO> DoSomething(IList<AddressEntity> addresses)
        {
            return addresses.Select(addresse => new AddressDTO()
            {
                FlatNo = addresse.FlatNo,
                BuildtingNo = addresse.BuildtingNo,
                Street = addresse.Street,
                ZipCode = addresse.ZipCode,
                City = addresse.City
            }).ToList().AsReadOnly();
        }
    }

    public class AddressDTO
    {
        public string FlatNo { get; set; }
        public string BuildtingNo { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
    }

    public class AddressEntity
    {
        public string FlatNo { get; set; }
        public string BuildtingNo { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
    }
}