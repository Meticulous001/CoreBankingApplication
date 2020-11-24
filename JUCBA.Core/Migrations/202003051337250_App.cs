namespace JUCBA.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class App : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AccountConfigurations", "CurrentCotIncomeGlID", "dbo.GlAccounts");
            DropForeignKey("dbo.AccountConfigurations", "CurrentInterestExpenseGlID", "dbo.GlAccounts");
            DropForeignKey("dbo.AccountConfigurations", "CurrentInterestPayableGlID", "dbo.GlAccounts");
            DropForeignKey("dbo.AccountConfigurations", "LoanInterestExpenseGLID", "dbo.GlAccounts");
            DropForeignKey("dbo.AccountConfigurations", "LoanInterestIncomeGlID", "dbo.GlAccounts");
            DropForeignKey("dbo.AccountConfigurations", "LoanInterestReceivableGlID", "dbo.GlAccounts");
            DropForeignKey("dbo.AccountConfigurations", "SavingsInterestPayableGlID", "dbo.GlAccounts");
            DropIndex("dbo.AccountConfigurations", new[] { "SavingsInterestPayableGlID" });
            DropIndex("dbo.AccountConfigurations", new[] { "CurrentInterestExpenseGlID" });
            DropIndex("dbo.AccountConfigurations", new[] { "CurrentCotIncomeGlID" });
            DropIndex("dbo.AccountConfigurations", new[] { "CurrentInterestPayableGlID" });
            DropIndex("dbo.AccountConfigurations", new[] { "LoanInterestIncomeGlID" });
            DropIndex("dbo.AccountConfigurations", new[] { "LoanInterestExpenseGLID" });
            DropIndex("dbo.AccountConfigurations", new[] { "LoanInterestReceivableGlID" });
            AlterColumn("dbo.AccountConfigurations", "SavingsInterestPayableGlID", c => c.Int(nullable: false));
            AlterColumn("dbo.AccountConfigurations", "CurrentInterestExpenseGlID", c => c.Int(nullable: false));
            AlterColumn("dbo.AccountConfigurations", "CurrentCotIncomeGlID", c => c.Int(nullable: false));
            AlterColumn("dbo.AccountConfigurations", "CurrentInterestPayableGlID", c => c.Int(nullable: false));
            AlterColumn("dbo.AccountConfigurations", "LoanInterestIncomeGlID", c => c.Int(nullable: false));
            AlterColumn("dbo.AccountConfigurations", "LoanInterestExpenseGLID", c => c.Int(nullable: false));
            AlterColumn("dbo.AccountConfigurations", "LoanInterestReceivableGlID", c => c.Int(nullable: false));
            CreateIndex("dbo.AccountConfigurations", "SavingsInterestPayableGlID");
            CreateIndex("dbo.AccountConfigurations", "CurrentInterestExpenseGlID");
            CreateIndex("dbo.AccountConfigurations", "CurrentCotIncomeGlID");
            CreateIndex("dbo.AccountConfigurations", "CurrentInterestPayableGlID");
            CreateIndex("dbo.AccountConfigurations", "LoanInterestIncomeGlID");
            CreateIndex("dbo.AccountConfigurations", "LoanInterestExpenseGLID");
            CreateIndex("dbo.AccountConfigurations", "LoanInterestReceivableGlID");
            AddForeignKey("dbo.AccountConfigurations", "CurrentCotIncomeGlID", "dbo.GlAccounts", "ID", cascadeDelete: true);
            AddForeignKey("dbo.AccountConfigurations", "CurrentInterestExpenseGlID", "dbo.GlAccounts", "ID");
            AddForeignKey("dbo.AccountConfigurations", "CurrentInterestPayableGlID", "dbo.GlAccounts", "ID");
            AddForeignKey("dbo.AccountConfigurations", "LoanInterestExpenseGLID", "dbo.GlAccounts", "ID");
            AddForeignKey("dbo.AccountConfigurations", "LoanInterestIncomeGlID", "dbo.GlAccounts", "ID");
            AddForeignKey("dbo.AccountConfigurations", "LoanInterestReceivableGlID", "dbo.GlAccounts", "ID");
            AddForeignKey("dbo.AccountConfigurations", "SavingsInterestPayableGlID", "dbo.GlAccounts", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AccountConfigurations", "SavingsInterestPayableGlID", "dbo.GlAccounts");
            DropForeignKey("dbo.AccountConfigurations", "LoanInterestReceivableGlID", "dbo.GlAccounts");
            DropForeignKey("dbo.AccountConfigurations", "LoanInterestIncomeGlID", "dbo.GlAccounts");
            DropForeignKey("dbo.AccountConfigurations", "LoanInterestExpenseGLID", "dbo.GlAccounts");
            DropForeignKey("dbo.AccountConfigurations", "CurrentInterestPayableGlID", "dbo.GlAccounts");
            DropForeignKey("dbo.AccountConfigurations", "CurrentInterestExpenseGlID", "dbo.GlAccounts");
            DropForeignKey("dbo.AccountConfigurations", "CurrentCotIncomeGlID", "dbo.GlAccounts");
            DropIndex("dbo.AccountConfigurations", new[] { "LoanInterestReceivableGlID" });
            DropIndex("dbo.AccountConfigurations", new[] { "LoanInterestExpenseGLID" });
            DropIndex("dbo.AccountConfigurations", new[] { "LoanInterestIncomeGlID" });
            DropIndex("dbo.AccountConfigurations", new[] { "CurrentInterestPayableGlID" });
            DropIndex("dbo.AccountConfigurations", new[] { "CurrentCotIncomeGlID" });
            DropIndex("dbo.AccountConfigurations", new[] { "CurrentInterestExpenseGlID" });
            DropIndex("dbo.AccountConfigurations", new[] { "SavingsInterestPayableGlID" });
            AlterColumn("dbo.AccountConfigurations", "LoanInterestReceivableGlID", c => c.Int());
            AlterColumn("dbo.AccountConfigurations", "LoanInterestExpenseGLID", c => c.Int());
            AlterColumn("dbo.AccountConfigurations", "LoanInterestIncomeGlID", c => c.Int());
            AlterColumn("dbo.AccountConfigurations", "CurrentInterestPayableGlID", c => c.Int());
            AlterColumn("dbo.AccountConfigurations", "CurrentCotIncomeGlID", c => c.Int());
            AlterColumn("dbo.AccountConfigurations", "CurrentInterestExpenseGlID", c => c.Int());
            AlterColumn("dbo.AccountConfigurations", "SavingsInterestPayableGlID", c => c.Int());
            CreateIndex("dbo.AccountConfigurations", "LoanInterestReceivableGlID");
            CreateIndex("dbo.AccountConfigurations", "LoanInterestExpenseGLID");
            CreateIndex("dbo.AccountConfigurations", "LoanInterestIncomeGlID");
            CreateIndex("dbo.AccountConfigurations", "CurrentInterestPayableGlID");
            CreateIndex("dbo.AccountConfigurations", "CurrentCotIncomeGlID");
            CreateIndex("dbo.AccountConfigurations", "CurrentInterestExpenseGlID");
            CreateIndex("dbo.AccountConfigurations", "SavingsInterestPayableGlID");
            AddForeignKey("dbo.AccountConfigurations", "SavingsInterestPayableGlID", "dbo.GlAccounts", "ID");
            AddForeignKey("dbo.AccountConfigurations", "LoanInterestReceivableGlID", "dbo.GlAccounts", "ID");
            AddForeignKey("dbo.AccountConfigurations", "LoanInterestIncomeGlID", "dbo.GlAccounts", "ID");
            AddForeignKey("dbo.AccountConfigurations", "LoanInterestExpenseGLID", "dbo.GlAccounts", "ID");
            AddForeignKey("dbo.AccountConfigurations", "CurrentInterestPayableGlID", "dbo.GlAccounts", "ID");
            AddForeignKey("dbo.AccountConfigurations", "CurrentInterestExpenseGlID", "dbo.GlAccounts", "ID");
            AddForeignKey("dbo.AccountConfigurations", "CurrentCotIncomeGlID", "dbo.GlAccounts", "ID");
        }
    }
}
