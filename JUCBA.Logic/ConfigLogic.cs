﻿using JUCBA.Core.Models;
using JUCBA.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUCBA.Logic
{
    public class ConfigLogic
    {
        GlAccountRepository glActRepo = new GlAccountRepository();

        public List<GlAccount> ExtractIncomeGLs()
        {
            var output = glActRepo.GetByMainCategory(MainGlCategory.Income);
            output.Insert(0, new GlAccount { ID = 0, AccountName = "--Select GL Account--" });

            return output;
        }

        public List<GlAccount> ExtractExpenseGLs()
        {
            var output = glActRepo.GetByMainCategory(MainGlCategory.Expenses);
            output.Insert(0, new GlAccount { ID = 0, AccountName = "--Select GL Account--" });

            return output;
        }

        public List<GlAccount> ExtractAssetGLs()
        {
            var output = glActRepo.GetByMainCategory(MainGlCategory.Asset);
            output.Insert(0, new GlAccount { ID = 0, AccountName = "--Select GL Account--" });

            return output;
        }

        public List<GlAccount> ExtractLiabilityGLs()
        {
            var output = glActRepo.GetByMainCategory(MainGlCategory.Liability);
            output.Insert(0, new GlAccount { ID = 0, AccountName = "--select--" });

            return output;
        }

    }
}
