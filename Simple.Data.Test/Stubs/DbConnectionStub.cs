﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Simple.Data.Test.Stubs
{
    class DbConnectionStub : IDbConnection
    {
        public IDbTransaction BeginTransaction(IsolationLevel il)
        {
            throw new NotImplementedException();
        }

        public IDbTransaction BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void ChangeDatabase(string databaseName)
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            
        }

        public string ConnectionString
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int ConnectionTimeout
        {
            get { throw new NotImplementedException(); }
        }

        public IDbCommand CreateCommand()
        {
            return new DbCommandStub();
        }

        public string Database
        {
            get { throw new NotImplementedException(); }
        }

        public void Open()
        {
            
        }

        public ConnectionState State
        {
            get { throw new NotImplementedException(); }
        }

        public void Dispose()
        {
        }
    }
}
