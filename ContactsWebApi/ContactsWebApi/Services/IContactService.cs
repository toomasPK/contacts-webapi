﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsWebApi.Models;

namespace ContactsWebApi.Services
{
     public interface IContactService
    {
        List<Contact> GetContacts();
        Contact GetContactById(int id);
        Contact GetContactByID(int id);
    }
}
