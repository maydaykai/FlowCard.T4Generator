-- delete the following assembly reference when you are using SQL2005

		create procedure Account_delete 
		@Id uniqueidentifier		as 
		delete from Account where	 
        Id = @Id


		create procedure AcSession_delete 
		@Id uniqueidentifier		as 
		delete from AcSession where	 
        Id = @Id


		create procedure AnyLog_delete 
		@Id uniqueidentifier		as 
		delete from AnyLog where	 
        Id = @Id


		create procedure AppSystem_delete 
		@Id uniqueidentifier		as 
		delete from AppSystem where	 
        Id = @Id


		create procedure Button_delete 
		@Id uniqueidentifier		as 
		delete from Button where	 
        Id = @Id


		create procedure Catalog_delete 
		@Id uniqueidentifier		as 
		delete from Catalog where	 
        Id = @Id


		create procedure DeveloperId_delete 
		@Id uniqueidentifier		as 
		delete from DeveloperId where	 
        Id = @Id


		create procedure DsdRole_delete 
		@Id uniqueidentifier		as 
		delete from DsdRole where	 
        Id = @Id


		create procedure DsdSet_delete 
		@Id uniqueidentifier		as 
		delete from DsdSet where	 
        Id = @Id


		create procedure EntityType_delete 
		@Id uniqueidentifier		as 
		delete from EntityType where	 
        Id = @Id


		create procedure ExceptionLog_delete 
		@Id uniqueidentifier		as 
		delete from ExceptionLog where	 
        Id = @Id


		create procedure Function_delete 
		@Id uniqueidentifier		as 
		delete from Function where	 
        Id = @Id


		create procedure Group_delete 
		@Id uniqueidentifier		as 
		delete from Group where	 
        Id = @Id


		create procedure Menu_delete 
		@Id uniqueidentifier		as 
		delete from Menu where	 
        Id = @Id


		create procedure OperationHelp_delete 
		@Id uniqueidentifier		as 
		delete from OperationHelp where	 
        Id = @Id


		create procedure OperationLog_delete 
		@Id uniqueidentifier		as 
		delete from OperationLog where	 
        Id = @Id


		create procedure Privilege_delete 
		@Id uniqueidentifier		as 
		delete from Privilege where	 
        Id = @Id


		create procedure Property_delete 
		@Id uniqueidentifier		as 
		delete from Property where	 
        Id = @Id


		create procedure RDatabase_delete 
		@Id uniqueidentifier		as 
		delete from RDatabase where	 
        Id = @Id


		create procedure Role_delete 
		@Id uniqueidentifier		as 
		delete from Role where	 
        Id = @Id


		create procedure SsdRole_delete 
		@Id uniqueidentifier		as 
		delete from SsdRole where	 
        Id = @Id


		create procedure SsdSet_delete 
		@Id uniqueidentifier		as 
		delete from SsdSet where	 
        Id = @Id


		create procedure UiView_delete 
		@Id uniqueidentifier		as 
		delete from UiView where	 
        Id = @Id


		create procedure UiViewButton_delete 
		@Id uniqueidentifier		as 
		delete from UiViewButton where	 
        Id = @Id


		create procedure VisitingLog_delete 
		@Id uniqueidentifier		as 
		delete from VisitingLog where	 
        Id = @Id


