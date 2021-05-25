using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace POS_API.Models
{
    public partial class EZSportsContext : DbContext
    {
        public EZSportsContext()
        {
        }

        public EZSportsContext(DbContextOptions<EZSportsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountIntegration> AccountIntegrations { get; set; }
        public virtual DbSet<AddOnsItem> AddOnsItems { get; set; }
        public virtual DbSet<AddOnsItemsView> AddOnsItemsViews { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<AppointmentDetail> AppointmentDetails { get; set; }
        public virtual DbSet<AppointmentHeader> AppointmentHeaders { get; set; }
        public virtual DbSet<Attachement> Attachements { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<AuditingView> AuditingViews { get; set; }
        public virtual DbSet<AutoPoVendorItemsView> AutoPoVendorItemsViews { get; set; }
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<BarcodePrint> BarcodePrints { get; set; }
        public virtual DbSet<BillAccount> BillAccounts { get; set; }
        public virtual DbSet<BillTransDetail> BillTransDetails { get; set; }
        public virtual DbSet<BillTransDetailsView> BillTransDetailsViews { get; set; }
        public virtual DbSet<BillTransHeader> BillTransHeaders { get; set; }
        public virtual DbSet<BillTransHeaderView> BillTransHeaderViews { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<CanceledSalesView> CanceledSalesViews { get; set; }
        public virtual DbSet<CardType> CardTypes { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CategorySalesProfitView> CategorySalesProfitViews { get; set; }
        public virtual DbSet<CategorySalesView> CategorySalesViews { get; set; }
        public virtual DbSet<Classification> Classifications { get; set; }
        public virtual DbSet<ClosingPeriod> ClosingPeriods { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanyCustomer> CompanyCustomers { get; set; }
        public virtual DbSet<CompanyModule> CompanyModules { get; set; }
        public virtual DbSet<CostCenter> CostCenters { get; set; }
        public virtual DbSet<Coupon> Coupons { get; set; }
        public virtual DbSet<CouponDetailsView> CouponDetailsViews { get; set; }
        public virtual DbSet<Courier> Couriers { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<CurrencyExchange> CurrencyExchanges { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerDiscountsLink> CustomerDiscountsLinks { get; set; }
        public virtual DbSet<CustomerProfileDocument> CustomerProfileDocuments { get; set; }
        public virtual DbSet<CustomerStatement> CustomerStatements { get; set; }
        public virtual DbSet<CustomerStatementView> CustomerStatementViews { get; set; }
        public virtual DbSet<CustomersDiscount> CustomersDiscounts { get; set; }
        public virtual DbSet<DdColumn> DdColumns { get; set; }
        public virtual DbSet<DdGrid> DdGrids { get; set; }
        public virtual DbSet<DdGridUserColumn> DdGridUserColumns { get; set; }
        public virtual DbSet<DdGridView> DdGridViews { get; set; }
        public virtual DbSet<DdView> DdViews { get; set; }
        public virtual DbSet<DdViewRelation> DdViewRelations { get; set; }
        public virtual DbSet<DeliveryArea> DeliveryAreas { get; set; }
        public virtual DbSet<DeliveryDetailsView> DeliveryDetailsViews { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EndOfdayView> EndOfdayViews { get; set; }
        public virtual DbSet<ErpCode> ErpCodes { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<FunctionsPermssion> FunctionsPermssions { get; set; }
        public virtual DbSet<GljournalDetailsView> GljournalDetailsViews { get; set; }
        public virtual DbSet<GljournalHeaderView> GljournalHeaderViews { get; set; }
        public virtual DbSet<GljournalsDetail> GljournalsDetails { get; set; }
        public virtual DbSet<GljournalsHeader> GljournalsHeaders { get; set; }
        public virtual DbSet<GridDescriptionView> GridDescriptionViews { get; set; }
        public virtual DbSet<HourlySalesReportView> HourlySalesReportViews { get; set; }
        public virtual DbSet<InsuranceCompany> InsuranceCompanies { get; set; }
        public virtual DbSet<InsuranceCompanyAttribute> InsuranceCompanyAttributes { get; set; }
        public virtual DbSet<InsuranceCompanyAttributeValue> InsuranceCompanyAttributeValues { get; set; }
        public virtual DbSet<InsuranceInvoiceAttributeDetail> InsuranceInvoiceAttributeDetails { get; set; }
        public virtual DbSet<InsuranceInvoiceDetail> InsuranceInvoiceDetails { get; set; }
        public virtual DbSet<InsurancePlanDetail> InsurancePlanDetails { get; set; }
        public virtual DbSet<InsurancePlaneHeader> InsurancePlaneHeaders { get; set; }
        public virtual DbSet<InventoryTransactionType> InventoryTransactionTypes { get; set; }
        public virtual DbSet<InvoicePayment> InvoicePayments { get; set; }
        public virtual DbSet<IssueCardsPayment> IssueCardsPayments { get; set; }
        public virtual DbSet<IssuePayment> IssuePayments { get; set; }
        public virtual DbSet<IssueTransHeader> IssueTransHeaders { get; set; }
        public virtual DbSet<IssueTransItem> IssueTransItems { get; set; }
        public virtual DbSet<IssueTransItemGuest> IssueTransItemGuests { get; set; }
        public virtual DbSet<IssueTransItemsAddOn> IssueTransItemsAddOns { get; set; }
        public virtual DbSet<IssueTransSplitted> IssueTransSplitteds { get; set; }
        public virtual DbSet<IssueTransactionType> IssueTransactionTypes { get; set; }
        public virtual DbSet<ItemAttributesValuesView> ItemAttributesValuesViews { get; set; }
        public virtual DbSet<ItemAverageCost> ItemAverageCosts { get; set; }
        public virtual DbSet<ItemAverageLandedCost> ItemAverageLandedCosts { get; set; }
        public virtual DbSet<ItemBalanceAndCostAtMomentView> ItemBalanceAndCostAtMomentViews { get; set; }
        public virtual DbSet<ItemBalanceAndPricesInStoreView> ItemBalanceAndPricesInStoreViews { get; set; }
        public virtual DbSet<ItemBalanceInStoresView> ItemBalanceInStoresViews { get; set; }
        public virtual DbSet<ItemCodeGeneration> ItemCodeGenerations { get; set; }
        public virtual DbSet<ItemColor> ItemColors { get; set; }
        public virtual DbSet<ItemCompanyPrice> ItemCompanyPrices { get; set; }
        public virtual DbSet<ItemExpiryDatesByRefrence> ItemExpiryDatesByRefrences { get; set; }
        public virtual DbSet<ItemExpiryDatesTemp> ItemExpiryDatesTemps { get; set; }
        public virtual DbSet<ItemExpiryDatesTemp2> ItemExpiryDatesTemp2s { get; set; }
        public virtual DbSet<ItemExpiryInTransfer> ItemExpiryInTransfers { get; set; }
        public virtual DbSet<ItemExpiryTempTransactionView> ItemExpiryTempTransactionViews { get; set; }
        public virtual DbSet<ItemGender> ItemGenders { get; set; }
        public virtual DbSet<ItemGroup> ItemGroups { get; set; }
        public virtual DbSet<ItemInfoView> ItemInfoViews { get; set; }
        public virtual DbSet<ItemMaster> ItemMasters { get; set; }
        public virtual DbSet<ItemMasterFromErp> ItemMasterFromErps { get; set; }
        public virtual DbSet<ItemMatrixValue> ItemMatricesValues { get; set; }
        public virtual DbSet<ItemMix> ItemMixes { get; set; }
        public virtual DbSet<ItemModel> ItemModels { get; set; }
        public virtual DbSet<ItemMovementOverCompanyView> ItemMovementOverCompanyViews { get; set; }
        public virtual DbSet<ItemMovementView> ItemMovementViews { get; set; }
        public virtual DbSet<ItemPurchaseHistory> ItemPurchaseHistories { get; set; }
        public virtual DbSet<ItemSalesPrice> ItemSalesPrices { get; set; }
        public virtual DbSet<ItemSalesPriceView> ItemSalesPriceViews { get; set; }
        public virtual DbSet<ItemSeason> ItemSeasons { get; set; }
        public virtual DbSet<ItemSerialNoAttributeRelation> ItemSerialNoAttributeRelations { get; set; }
        public virtual DbSet<ItemSerialNoAttributesValue> ItemSerialNoAttributesValues { get; set; }
        public virtual DbSet<ItemSerialNoAttributesValuesView> ItemSerialNoAttributesValuesViews { get; set; }
        public virtual DbSet<ItemSerialNoTemp> ItemSerialNoTemps { get; set; }
        public virtual DbSet<ItemSerialNoTempAttributesValue> ItemSerialNoTempAttributesValues { get; set; }
        public virtual DbSet<ItemSerialNoTempAttributesValuesView> ItemSerialNoTempAttributesValuesViews { get; set; }
        public virtual DbSet<ItemSerialNoTempView> ItemSerialNoTempViews { get; set; }
        public virtual DbSet<ItemSerialNoTransaction> ItemSerialNoTransactions { get; set; }
        public virtual DbSet<ItemSerialNoTransactionInOutView> ItemSerialNoTransactionInOutViews { get; set; }
        public virtual DbSet<ItemSerialsNumber> ItemSerialsNumbers { get; set; }
        public virtual DbSet<ItemSize> ItemSizes { get; set; }
        public virtual DbSet<ItemStatusChange> ItemStatusChanges { get; set; }
        public virtual DbSet<ItemStoreCompany> ItemStoreCompanies { get; set; }
        public virtual DbSet<ItemStoreDetail> ItemStoreDetails { get; set; }
        public virtual DbSet<ItemStoreExpiryDataView> ItemStoreExpiryDataViews { get; set; }
        public virtual DbSet<ItemStoreExpiryDate> ItemStoreExpiryDates { get; set; }
        public virtual DbSet<ItemStoreSerialNo> ItemStoreSerialNos { get; set; }
        public virtual DbSet<ItemStoreSerialNoStockInOutView> ItemStoreSerialNoStockInOutViews { get; set; }
        public virtual DbSet<ItemStoreView> ItemStoreViews { get; set; }
        public virtual DbSet<ItemTransactionPicture> ItemTransactionPictures { get; set; }
        public virtual DbSet<ItemType> ItemTypes { get; set; }
        public virtual DbSet<ItemUnit> ItemUnits { get; set; }
        public virtual DbSet<ItemUpload> ItemUploads { get; set; }
        public virtual DbSet<ItemVendor> ItemVendors { get; set; }
        public virtual DbSet<ItemVendorsView> ItemVendorsViews { get; set; }
        public virtual DbSet<ItemsWithUnitsView> ItemsWithUnitsViews { get; set; }
        public virtual DbSet<JournalType> JournalTypes { get; set; }
        public virtual DbSet<Kitchen> Kitchens { get; set; }
        public virtual DbSet<KitchenOrder> KitchenOrders { get; set; }
        public virtual DbSet<KitchenStore> KitchenStores { get; set; }
        public virtual DbSet<Label> Labels { get; set; }
        public virtual DbSet<LevelsAddOn> LevelsAddOns { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<LogAction> LogActions { get; set; }
        public virtual DbSet<LoyaltySetupDetail> LoyaltySetupDetails { get; set; }
        public virtual DbSet<LoyaltySetupHeader> LoyaltySetupHeaders { get; set; }
        public virtual DbSet<MarketingCompaniesPeriod> MarketingCompaniesPeriods { get; set; }
        public virtual DbSet<MarketingCompany> MarketingCompanies { get; set; }
        public virtual DbSet<MastersSerial> MastersSerials { get; set; }
        public virtual DbSet<MaxSerialsView> MaxSerialsViews { get; set; }
        public virtual DbSet<ModelAttribute> ModelAttributes { get; set; }
        public virtual DbSet<ModelAttributeValue> ModelAttributeValues { get; set; }
        public virtual DbSet<Nationality> Nationalities { get; set; }
        public virtual DbSet<Object> Objects { get; set; }
        public virtual DbSet<Offer> Offers { get; set; }
        public virtual DbSet<PaymentLineInvoice> PaymentLineInvoices { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<PaymentVoucherDetailsView> PaymentVoucherDetailsViews { get; set; }
        public virtual DbSet<PaymentVoucherHeaderView> PaymentVoucherHeaderViews { get; set; }
        public virtual DbSet<PaymentVouchersDetail> PaymentVouchersDetails { get; set; }
        public virtual DbSet<PaymentVouchersHeader> PaymentVouchersHeaders { get; set; }
        public virtual DbSet<PriceListAssigning> PriceListAssignings { get; set; }
        public virtual DbSet<PriceListAssigningTypesView> PriceListAssigningTypesViews { get; set; }
        public virtual DbSet<PriceListDetail> PriceListDetails { get; set; }
        public virtual DbSet<PriceListHeader> PriceListHeaders { get; set; }
        public virtual DbSet<Printer> Printers { get; set; }
        public virtual DbSet<PromotionDetail> PromotionDetails { get; set; }
        public virtual DbSet<PromotionHeader> PromotionHeaders { get; set; }
        public virtual DbSet<PurchaseInvoiceDetailsView> PurchaseInvoiceDetailsViews { get; set; }
        public virtual DbSet<PurchaseInvoiceHeaderView> PurchaseInvoiceHeaderViews { get; set; }
        public virtual DbSet<PurchaseInvoicePrintView> PurchaseInvoicePrintViews { get; set; }
        public virtual DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public virtual DbSet<PurchaseOrderDetailsView> PurchaseOrderDetailsViews { get; set; }
        public virtual DbSet<PurchaseOrderDetialsView> PurchaseOrderDetialsViews { get; set; }
        public virtual DbSet<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }
        public virtual DbSet<PurchaseOrderHeaderView> PurchaseOrderHeaderViews { get; set; }
        public virtual DbSet<PurchaseOrderView> PurchaseOrderViews { get; set; }
        public virtual DbSet<PurchaseRequestDetail> PurchaseRequestDetails { get; set; }
        public virtual DbSet<PurchaseRequestDetailsView> PurchaseRequestDetailsViews { get; set; }
        public virtual DbSet<PurchaseRequestHeader> PurchaseRequestHeaders { get; set; }
        public virtual DbSet<PurchaseRequestHeaderView> PurchaseRequestHeaderViews { get; set; }
        public virtual DbSet<PurchaseReturnDetailsView> PurchaseReturnDetailsViews { get; set; }
        public virtual DbSet<PurchaseReturnHeaderView> PurchaseReturnHeaderViews { get; set; }
        public virtual DbSet<PurchaseReturnView> PurchaseReturnViews { get; set; }
        public virtual DbSet<PurchasingItemByVendorView> PurchasingItemByVendorViews { get; set; }
        public virtual DbSet<QuotationDetailsView> QuotationDetailsViews { get; set; }
        public virtual DbSet<QuotationHeaderView> QuotationHeaderViews { get; set; }
        public virtual DbSet<Reason> Reasons { get; set; }
        public virtual DbSet<ReceivingItemsTempCollector> ReceivingItemsTempCollectors { get; set; }
        public virtual DbSet<RecieveTransHeader> RecieveTransHeaders { get; set; }
        public virtual DbSet<RecieveTransItem> RecieveTransItems { get; set; }
        public virtual DbSet<RecipeItemsDetail> RecipeItemsDetails { get; set; }
        public virtual DbSet<RegLogUser> RegLogUsers { get; set; }
        public virtual DbSet<Remark> Remarks { get; set; }
        public virtual DbSet<RequisitionDetailsView> RequisitionDetailsViews { get; set; }
        public virtual DbSet<RequisitionHeader> RequisitionHeaders { get; set; }
        public virtual DbSet<RequisitionHeaderView> RequisitionHeaderViews { get; set; }
        public virtual DbSet<RequisitionItem> RequisitionItems { get; set; }
        public virtual DbSet<RequisitionView> RequisitionViews { get; set; }
        public virtual DbSet<ReservationCompanion> ReservationCompanions { get; set; }
        public virtual DbSet<ReservationHeader> ReservationHeaders { get; set; }
        public virtual DbSet<RetailCustomer> RetailCustomers { get; set; }
        public virtual DbSet<RetailCustomerPointsStatement> RetailCustomerPointsStatements { get; set; }
        public virtual DbSet<ReturnedSalesView> ReturnedSalesViews { get; set; }
        public virtual DbSet<SalesDetailsView> SalesDetailsViews { get; set; }
        public virtual DbSet<SalesHeaderView> SalesHeaderViews { get; set; }
        public virtual DbSet<SalesItemDetailsView> SalesItemDetailsViews { get; set; }
        public virtual DbSet<SalesMan> SalesMen { get; set; }
        public virtual DbSet<SalesManItem> SalesManItems { get; set; }
        public virtual DbSet<SalesOrderDeliverySchedule> SalesOrderDeliverySchedules { get; set; }
        public virtual DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }
        public virtual DbSet<SalesOrderDetailsView> SalesOrderDetailsViews { get; set; }
        public virtual DbSet<SalesOrderHeader> SalesOrderHeaders { get; set; }
        public virtual DbSet<SalesOrderHeaderView> SalesOrderHeaderViews { get; set; }
        public virtual DbSet<SalesOrderReturnDetailsView> SalesOrderReturnDetailsViews { get; set; }
        public virtual DbSet<SalesOrderReturnHeaderView> SalesOrderReturnHeaderViews { get; set; }
        public virtual DbSet<SalesPriceType> SalesPriceTypes { get; set; }
        public virtual DbSet<SecurityUser> SecurityUsers { get; set; }
        public virtual DbSet<SecurityUsersGroup> SecurityUsersGroups { get; set; }
        public virtual DbSet<Serial> Serials { get; set; }
        public virtual DbSet<SerialNoAttribute> SerialNoAttributes { get; set; }
        public virtual DbSet<SerialNoAttributeValue> SerialNoAttributeValues { get; set; }
        public virtual DbSet<SerialNoUnitCost> SerialNoUnitCosts { get; set; }
        public virtual DbSet<Shift> Shifts { get; set; }
        public virtual DbSet<ShiftsDay> ShiftsDays { get; set; }
        public virtual DbSet<SoldItemsAsTransactionView> SoldItemsAsTransactionViews { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<StkAdjustmentDetailsView> StkAdjustmentDetailsViews { get; set; }
        public virtual DbSet<StkAdjustmentView> StkAdjustmentViews { get; set; }
        public virtual DbSet<StockAdjustmentDetailsView> StockAdjustmentDetailsViews { get; set; }
        public virtual DbSet<StockAdjustmentHeaderView> StockAdjustmentHeaderViews { get; set; }
        public virtual DbSet<StockAdjustmentView> StockAdjustmentViews { get; set; }
        public virtual DbSet<StockBalanceView> StockBalanceViews { get; set; }
        public virtual DbSet<StockTakeDetail> StockTakeDetails { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<StoreAccountCode> StoreAccountCodes { get; set; }
        public virtual DbSet<StoreVoucherDetail> StoreVoucherDetails { get; set; }
        public virtual DbSet<StoreVoucherDetailsView> StoreVoucherDetailsViews { get; set; }
        public virtual DbSet<StoreVoucherHeader> StoreVoucherHeaders { get; set; }
        public virtual DbSet<StoreVoucherHeaderBeneficiaryDetail> StoreVoucherHeaderBeneficiaryDetails { get; set; }
        public virtual DbSet<StoreVoucherHeaderView> StoreVoucherHeaderViews { get; set; }
        public virtual DbSet<StoreVouchersType> StoreVouchersTypes { get; set; }
        public virtual DbSet<SubStoreItemTransactionTemp> SubStoreItemTransactionTemps { get; set; }
        public virtual DbSet<SubStoreItemTransactionTempView> SubStoreItemTransactionTempViews { get; set; }
        public virtual DbSet<SystemAuditing> SystemAuditings { get; set; }
        public virtual DbSet<SystemContact> SystemContacts { get; set; }
        public virtual DbSet<SystemLog> SystemLogs { get; set; }
        public virtual DbSet<SystemParameter> SystemParameters { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<TablesTemp1> TablesTemp1s { get; set; }
        public virtual DbSet<TaxTemplate> TaxTemplates { get; set; }
        public virtual DbSet<TaxType> TaxTypes { get; set; }
        public virtual DbSet<TempTransTable> TempTransTables { get; set; }
        public virtual DbSet<Terminal> Terminals { get; set; }
        public virtual DbSet<TerminalAccountCode> TerminalAccountCodes { get; set; }
        public virtual DbSet<Terminology> Terminologies { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<TransactionsEvent> TransactionsEvents { get; set; }
        public virtual DbSet<TransactionsTemp> TransactionsTemps { get; set; }
        public virtual DbSet<TransferDetailsView> TransferDetailsViews { get; set; }
        public virtual DbSet<TransferHeaderView> TransferHeaderViews { get; set; }
        public virtual DbSet<TransferRecieveDetailsView> TransferRecieveDetailsViews { get; set; }
        public virtual DbSet<TransferRecieveHeaderView> TransferRecieveHeaderViews { get; set; }
        public virtual DbSet<TransferView> TransferViews { get; set; }
        public virtual DbSet<Treasury> Treasuries { get; set; }
        public virtual DbSet<TreasuryStatement> TreasuryStatements { get; set; }
        public virtual DbSet<UserCompany> UserCompanies { get; set; }
        public virtual DbSet<UserCompanyStore> UserCompanyStores { get; set; }
        public virtual DbSet<UserFunctionsPermission> UserFunctionsPermissions { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<VendorStatement> VendorStatements { get; set; }
        public virtual DbSet<VendorStatementView> VendorStatementViews { get; set; }
        public virtual DbSet<ViewItem> ViewItems { get; set; }
        public virtual DbSet<WorkOrderDetailsView> WorkOrderDetailsViews { get; set; }
        public virtual DbSet<WorkOrderHeaderView> WorkOrderHeaderViews { get; set; }
        public virtual DbSet<Xreport> Xreports { get; set; }
        public virtual DbSet<XreportView> XreportViews { get; set; }
        public virtual DbSet<Xx> Xxes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=EZSports;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Arabic_100_CI_AI_KS_WS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("ACCOUNTS");

                entity.Property(e => e.AccountId)
                    .ValueGeneratedNever()
                    .HasColumnName("ACCOUNT_ID");

                entity.Property(e => e.AccountType).HasColumnName("ACCOUNT_TYPE");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CurrenciesId).HasColumnName("CURRENCIES_ID");

                entity.Property(e => e.DebitCreditType).HasColumnName("DEBIT_CREDIT_TYPE");

                entity.Property(e => e.MainSubType).HasColumnName("MAIN_SUB_TYPE");

                entity.Property(e => e.ParentAccountId).HasColumnName("PARENT_ACCOUNT_ID");

                entity.Property(e => e.PrimaryName)
                    .HasMaxLength(250)
                    .HasColumnName("PRIMARY_NAME");

                entity.Property(e => e.RestrictedAccount).HasColumnName("RESTRICTED_ACCOUNT");

                entity.Property(e => e.SecondaryName)
                    .HasMaxLength(250)
                    .HasColumnName("SECONDARY_NAME");

                entity.Property(e => e.TreeLevel).HasColumnName("TREE_LEVEL");

                entity.Property(e => e.UserCode)
                    .HasMaxLength(50)
                    .HasColumnName("USER_CODE");
            });

            modelBuilder.Entity<AccountIntegration>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.LineNo });

                entity.ToTable("ACCOUNT_INTEGRATIONS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LineNo)
                    .HasColumnType("numeric(15, 0)")
                    .HasColumnName("LINE_NO");

                entity.Property(e => e.AccountId)
                    .HasColumnType("numeric(15, 0)")
                    .HasColumnName("ACCOUNT_ID");

                entity.Property(e => e.AmountFc)
                    .HasColumnType("numeric(17, 5)")
                    .HasColumnName("AMOUNT_FC");

                entity.Property(e => e.BankId).HasColumnName("BANK_ID");

                entity.Property(e => e.BranchId)
                    .HasColumnType("numeric(15, 0)")
                    .HasColumnName("BRANCH_ID");

                entity.Property(e => e.CheckDate)
                    .HasColumnType("date")
                    .HasColumnName("CHECK_DATE");

                entity.Property(e => e.CheckNo)
                    .HasMaxLength(25)
                    .HasColumnName("CHECK_NO");

                entity.Property(e => e.CihostSerial)
                    .HasMaxLength(25)
                    .HasColumnName("CIHOST_SERIAL");

                entity.Property(e => e.CihostType)
                    .HasColumnType("numeric(15, 0)")
                    .HasColumnName("CIHOST_TYPE");

                entity.Property(e => e.ConversionRate)
                    .HasColumnType("numeric(17, 5)")
                    .HasColumnName("CONVERSION_RATE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CostCenterId)
                    .HasColumnType("numeric(15, 0)")
                    .HasColumnName("COST_CENTER_ID");

                entity.Property(e => e.CurrenciesId)
                    .HasColumnType("numeric(15, 0)")
                    .HasColumnName("CURRENCIES_ID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DebitCreditMarker)
                    .HasMaxLength(1)
                    .HasColumnName("DEBIT_CREDIT_MARKER")
                    .IsFixedLength(true);

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("numeric(15, 0)")
                    .HasColumnName("DEPARTMENT_ID");

                entity.Property(e => e.DocumentTypesId)
                    .HasColumnType("numeric(15, 0)")
                    .HasColumnName("DOCUMENT_TYPES_ID")
                    .HasDefaultValueSql("((28))");

                entity.Property(e => e.JournalDate)
                    .HasColumnType("date")
                    .HasColumnName("JOURNAL_DATE");

                entity.Property(e => e.JournalDtlDesc).HasColumnName("JOURNAL_DTL_DESC");

                entity.Property(e => e.JournalHdrDesc).HasColumnName("JOURNAL_HDR_DESC");

                entity.Property(e => e.JournalNo)
                    .HasMaxLength(25)
                    .HasColumnName("JOURNAL_NO");

                entity.Property(e => e.JournalTypesId)
                    .HasColumnType("numeric(15, 0)")
                    .HasColumnName("JOURNAL_TYPES_ID")
                    .HasDefaultValueSql("((4))");

                entity.Property(e => e.PostedDocumentId)
                    .HasColumnType("numeric(15, 0)")
                    .HasColumnName("POSTED_DOCUMENT_ID");

                entity.Property(e => e.SetlFor)
                    .HasMaxLength(50)
                    .HasColumnName("SETL_FOR");

                entity.Property(e => e.SetlRef)
                    .HasMaxLength(50)
                    .HasColumnName("SETL_REF");

                entity.Property(e => e.TransNo).HasMaxLength(50);
            });

            modelBuilder.Entity<AddOnsItem>(entity =>
            {
                entity.HasKey(e => new { e.ItemSerial, e.LevelId, e.ItemSerialAddOns });

                entity.Property(e => e.ItemSerial).HasColumnName("itemSerial");

                entity.Property(e => e.LevelId).HasColumnName("LevelID");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<AddOnsItemsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AddOnsItems_View");

                entity.Property(e => e.AddOnsItemSalesUnitCode).HasMaxLength(10);

                entity.Property(e => e.AddOnsItemSalesUnitNameL1).HasMaxLength(50);

                entity.Property(e => e.AddOnsItemSalesUnitNameL2).HasMaxLength(50);

                entity.Property(e => e.LevelId).HasColumnName("LevelID");

                entity.Property(e => e.LevelQtyCheckDesc)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("Appointment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.End).HasColumnType("datetime");

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.Owner).HasMaxLength(50);

                entity.Property(e => e.Properities).IsRequired();

                entity.Property(e => e.Start).HasColumnType("datetime");

                entity.Property(e => e.Subject).IsRequired();
            });

            modelBuilder.Entity<AppointmentDetail>(entity =>
            {
                entity.HasKey(e => new { e.AppNo, e.AppLineSerial });

                entity.Property(e => e.AppNo).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.MajorTime).HasMaxLength(50);

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SalesManId).HasColumnName("SalesManID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<AppointmentHeader>(entity =>
            {
                entity.HasKey(e => e.AppNo);

                entity.ToTable("AppointmentHeader");

                entity.Property(e => e.AppNo).HasMaxLength(50);

                entity.Property(e => e.AppDate).HasColumnType("date");

                entity.Property(e => e.AppEndTime).HasColumnType("datetime");

                entity.Property(e => e.AppReasons).HasMaxLength(50);

                entity.Property(e => e.AppStartTime).HasColumnType("datetime");

                entity.Property(e => e.AppTotalValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerPhone).HasMaxLength(50);

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.SalesTerminalId).HasColumnName("SalesTerminalID");

                entity.Property(e => e.SalesTransNo).HasMaxLength(50);

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TableId).HasColumnName("TableID");

                entity.Property(e => e.TotalAppTime).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<Attachement>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DisplayName).HasMaxLength(200);

                entity.Property(e => e.Extension).HasMaxLength(10);

                entity.Property(e => e.FileName).HasMaxLength(150);

                entity.Property(e => e.RefrenceId).HasColumnName("RefrenceID");

                entity.Property(e => e.RefrenceTransaction).HasMaxLength(50);

                entity.Property(e => e.UploadBy).HasMaxLength(100);

                entity.Property(e => e.UploadDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.HasKey(e => e.TrnsId);

                entity.ToTable("Attendance");

                entity.Property(e => e.TrnsId).HasColumnName("TrnsID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.StoCode).HasMaxLength(50);

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.TransactionDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AuditingView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Auditing_View");

                entity.Property(e => e.LogEnd).HasColumnType("datetime");

                entity.Property(e => e.LogStart).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .IsUnicode(false)
                    .HasColumnName("USER_NAME");
            });

            modelBuilder.Entity<AutoPoVendorItemsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AutoPO_VendorItems_View");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.LastPurchaseDate).HasColumnType("date");

                entity.Property(e => e.NameL1).IsRequired();

                entity.Property(e => e.PurchasePrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.VedorId).HasColumnName("VedorID");

                entity.Property(e => e.VendorName).IsRequired();
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BankAccountNo).HasMaxLength(50);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Credit).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Debit).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.GlaccountCode)
                    .HasMaxLength(50)
                    .HasColumnName("GLAccountCode");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid).HasColumnName("InsertUID");
            });

            modelBuilder.Entity<BarcodePrint>(entity =>
            {
                entity.HasKey(e => e.Serial);

                entity.ToTable("BarcodePrint");

                entity.Property(e => e.BatchNo).HasMaxLength(50);

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.ItemCode).HasMaxLength(50);

                entity.Property(e => e.ItemSalesPrice).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<BillAccount>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .IsFixedLength(true)
                    .HasComment("1=Expenses");

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.InserUid)
                    .HasMaxLength(50)
                    .HasColumnName("InserUID");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PreferedVendorId).HasColumnName("PreferedVendorID");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'1')")
                    .IsFixedLength(true);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<BillTransDetail>(entity =>
            {
                entity.HasKey(e => e.BillTransSerial)
                    .HasName("PK_BillTransDetails_1");

                entity.Property(e => e.AccId).HasColumnName("AccID");

                entity.Property(e => e.AccInputCode).HasMaxLength(50);

                entity.Property(e => e.BillTransNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ComCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(getdate())", false);

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.LineDiscountValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.LinePrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.LineQty).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TotalCustomValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalLineValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(getdate())", false);

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VatValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Year)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<BillTransDetailsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BillTransDetails_View");

                entity.Property(e => e.AccId).HasColumnName("AccID");

                entity.Property(e => e.BillTransNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.LineDiscountValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.LinePrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.LineQty).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalLineValue).HasColumnType("decimal(18, 5)");
            });

            modelBuilder.Entity<BillTransHeader>(entity =>
            {
                entity.HasKey(e => new { e.ComCode, e.StoCode, e.TransNo });

                entity.ToTable("BillTransHeader");

                entity.Property(e => e.ComCode).HasMaxLength(10);

                entity.Property(e => e.StoCode).HasMaxLength(50);

                entity.Property(e => e.TransNo).HasMaxLength(50);

                entity.Property(e => e.BaseCurrencyCode).HasMaxLength(10);

                entity.Property(e => e.BaseNetAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BasePaidAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BaseTotalDiscountValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BaseTotalOthersValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BaseTotalTaxValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BaseTotalValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BillDate).HasColumnType("date");

                entity.Property(e => e.BillNo).HasMaxLength(50);

                entity.Property(e => e.CurrencyCode).HasMaxLength(50);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(getdate())", false);

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.PostFlag)
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.Property(e => e.PostingDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RelatedToInvoice).HasMaxLength(50);

                entity.Property(e => e.TotalDiscountValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalTaxValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalVat)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("TotalVAT");

                entity.Property(e => e.TransDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(getdate())", false);

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<BillTransHeaderView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BillTransHeader_View");

                entity.Property(e => e.BaseCurrencyCode).HasMaxLength(10);

                entity.Property(e => e.BaseNetAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BasePaidAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BaseTotalDiscountValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BaseTotalOthersValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BaseTotalTaxValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BaseTotalValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BillDate).HasColumnType("date");

                entity.Property(e => e.BillNo).HasMaxLength(50);

                entity.Property(e => e.ComCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CompanyName1).IsRequired();

                entity.Property(e => e.CurrencyCode).HasMaxLength(50);

                entity.Property(e => e.CurrencyName1).HasMaxLength(50);

                entity.Property(e => e.CurrencyName2).HasMaxLength(50);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.PostFlag)
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.RelatedToInvoice).HasMaxLength(50);

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StoreName1).IsRequired();

                entity.Property(e => e.Sympol)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TotalDiscountValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalTaxValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalVat)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("TotalVAT");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.TransNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");

                entity.Property(e => e.VendorName1).IsRequired();
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BrnCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CompanyCode).HasMaxLength(50);

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(getdate())", false);

                entity.Property(e => e.NameL1).IsRequired();

                entity.Property(e => e.NameL2).IsRequired();

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<CanceledSalesView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CanceledSales_View");

                entity.Property(e => e.BeforeDiscountPrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.InsertUid).HasMaxLength(50);

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasColumnName("Item_Name");

                entity.Property(e => e.ItemTotal).HasColumnType("decimal(37, 10)");

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.ModelCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SalesTrnsId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TerminalId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TransSerial)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TransType1).HasMaxLength(50);

                entity.Property(e => e.TrnsDate).HasColumnType("date");

                entity.Property(e => e.TrnsQty).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.UnitSalesPrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.XAttributeValue)
                    .IsRequired()
                    .HasColumnName("X_AttributeValue");

                entity.Property(e => e.YAttributeValue)
                    .IsRequired()
                    .HasColumnName("Y_AttributeValue");

                entity.Property(e => e.Year)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<CardType>(entity =>
            {
                entity.ToTable("CardType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BankPercent).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.NameL1)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.NameL2)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Color).HasComment("The Value Represent the conversion from color to Argb.");

                entity.Property(e => e.Erpcode)
                    .HasMaxLength(50)
                    .HasColumnName("ERPCode");

                entity.Property(e => e.Picture).HasColumnType("image");

                entity.Property(e => e.PrinterName).HasColumnName("printerName");
            });

            modelBuilder.Entity<CategorySalesProfitView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CategorySalesProfit_View");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InsertDate).HasColumnType("date");

                entity.Property(e => e.PercentFromTotal).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Profit).HasColumnType("decimal(38, 10)");

                entity.Property(e => e.Qty).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.TotalAfterDiscount).HasColumnType("decimal(38, 10)");

                entity.Property(e => e.TotalBeforDiscount).HasColumnType("decimal(38, 10)");

                entity.Property(e => e.TotalCost).HasColumnType("decimal(38, 10)");

                entity.Property(e => e.TotalDiscount).HasColumnType("decimal(38, 5)");
            });

            modelBuilder.Entity<CategorySalesView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CategorySales_view");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.ComCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CompanyName).IsRequired();

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NetTotal).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Qty).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StoName).IsRequired();

                entity.Property(e => e.Total).HasColumnType("decimal(38, 9)");

                entity.Property(e => e.UserCode).HasMaxLength(50);
            });

            modelBuilder.Entity<Classification>(entity =>
            {
                entity.Property(e => e.ClassificationId).HasColumnName("ClassificationID");

                entity.Property(e => e.Classification1).HasColumnName("Classification");

                entity.Property(e => e.MainClassificationId).HasColumnName("MainClassificationID");
            });

            modelBuilder.Entity<ClosingPeriod>(entity =>
            {
                entity.ToTable("ClosingPeriod");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.ScreenShot).HasColumnType("image");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("Company");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.ComCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CompanyAccountCode).HasMaxLength(50);

                entity.Property(e => e.CompanyAccountId).HasColumnName("CompanyAccountID");

                entity.Property(e => e.CompanyEmail).HasMaxLength(50);

                entity.Property(e => e.CreationDate).HasColumnType("date");

                entity.Property(e => e.CurrencyCode).HasMaxLength(50);

                entity.Property(e => e.DefaultPurchaseCurrency).HasMaxLength(50);

                entity.Property(e => e.ErpBranchId).HasColumnName("ERP_BRANCH_ID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(getdate())", false);

                entity.Property(e => e.MinimumChargeValue)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NameL1).IsRequired();

                entity.Property(e => e.Pobox)
                    .HasMaxLength(25)
                    .HasColumnName("POBox");

                entity.Property(e => e.ProductionStoCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('998')");

                entity.Property(e => e.ServiceChargePercent)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SuffixCode).HasMaxLength(5);

                entity.Property(e => e.TaxPercent)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Telephone1).HasMaxLength(25);

                entity.Property(e => e.Telephone2).HasMaxLength(25);

                entity.Property(e => e.TransferStoCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('999')");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<CompanyCustomer>(entity =>
            {
                entity.HasKey(e => new { e.ComCode, e.CusSerial });

                entity.Property(e => e.ComCode)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<CompanyModule>(entity =>
            {
                entity.HasKey(e => e.ModuleId);

                entity.Property(e => e.ModuleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ModuleID");

                entity.Property(e => e.ComCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Installed)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Integrated)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CostCenter>(entity =>
            {
                entity.ToTable("COST_CENTERS");

                entity.Property(e => e.CostCenterId)
                    .ValueGeneratedNever()
                    .HasColumnName("COST_CENTER_ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.MainSubType).HasColumnName("MAIN_SUB_TYPE");

                entity.Property(e => e.ParentCostCenterId).HasColumnName("PARENT_COST_CENTER_ID");

                entity.Property(e => e.PrimaryName)
                    .HasMaxLength(250)
                    .HasColumnName("PRIMARY_NAME");

                entity.Property(e => e.SecondaryName)
                    .HasMaxLength(250)
                    .HasColumnName("SECONDARY_NAME");

                entity.Property(e => e.TreeLevel).HasColumnName("TREE_LEVEL");

                entity.Property(e => e.UserCode)
                    .HasMaxLength(50)
                    .HasColumnName("USER_CODE");
            });

            modelBuilder.Entity<Coupon>(entity =>
            {
                entity.HasKey(e => new { e.CouponId, e.MarkComId });

                entity.ToTable("Coupon");

                entity.Property(e => e.CouponId)
                    .HasMaxLength(50)
                    .HasColumnName("Coupon_id");

                entity.Property(e => e.MarkComId)
                    .HasColumnName("MarkComID")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.CouponFlag)
                    .HasMaxLength(1)
                    .HasColumnName("Coupon_Flag");

                entity.Property(e => e.CouponType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("Coupon_Type");

                entity.Property(e => e.CouponValue)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("Coupon_Value");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.PeriodId)
                    .HasColumnName("PeriodID")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.SoldTransNo).HasMaxLength(50);

                entity.Property(e => e.SoldTransStoCode).HasMaxLength(25);

                entity.Property(e => e.SoldTransTerminalId).HasColumnName("SoldTransTerminalID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");

                entity.Property(e => e.UsedTransNo).HasMaxLength(50);

                entity.Property(e => e.UsedTransStoCode).HasMaxLength(25);

                entity.Property(e => e.UsedTransTerminalId).HasColumnName("UsedTransTerminalID");
            });

            modelBuilder.Entity<CouponDetailsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CouponDetails_View");

                entity.Property(e => e.CouponAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CouponDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CouponId).HasColumnName("Coupon_id");

                entity.Property(e => e.CouponTypeDesc)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CouponValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DateSold).HasColumnType("datetime");

                entity.Property(e => e.DateUsed).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.MarkComId).HasColumnName("MarkComID");

                entity.Property(e => e.SoldStoreName).IsRequired();

                entity.Property(e => e.SoldTerminalName).IsRequired();

                entity.Property(e => e.SoldTransNo).HasMaxLength(50);

                entity.Property(e => e.SoldTransStoCode).HasMaxLength(25);

                entity.Property(e => e.SoldTransTerminalId).HasColumnName("SoldTransTerminalID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UsedStoreName).IsRequired();

                entity.Property(e => e.UsedTerminalName).IsRequired();

                entity.Property(e => e.UsedTransNo).HasMaxLength(50);

                entity.Property(e => e.UsedTransStoCode).HasMaxLength(25);

                entity.Property(e => e.UsedTransTerminalId).HasColumnName("UsedTransTerminalID");
            });

            modelBuilder.Entity<Courier>(entity =>
            {
                entity.ToTable("Courier");

                entity.Property(e => e.CourierId).HasColumnName("CourierID");

                entity.Property(e => e.CashOnDelivery).HasDefaultValueSql("((1))");

                entity.Property(e => e.CourierCode).HasMaxLength(50);

                entity.Property(e => e.CreditCustomerId).HasColumnName("CreditCustomerID");

                entity.Property(e => e.OnlinePayment).HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.HasKey(e => e.CurrencyCode);

                entity.ToTable("Currency");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(3)
                    .IsFixedLength(true);

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(10)
                    .HasColumnName("InsertUID")
                    .IsFixedLength(true);

                entity.Property(e => e.NameL1).HasMaxLength(50);

                entity.Property(e => e.NameL2).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(100);

                entity.Property(e => e.Sympol)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(10)
                    .HasColumnName("UpdateUID")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<CurrencyExchange>(entity =>
            {
                entity.HasKey(e => new { e.ExBaseCode, e.ExCurrencyCode, e.ExchangeDate });

                entity.ToTable("CurrencyExchange");

                entity.Property(e => e.ExBaseCode)
                    .HasMaxLength(3)
                    .IsFixedLength(true);

                entity.Property(e => e.ExCurrencyCode)
                    .HasMaxLength(3)
                    .IsFixedLength(true);

                entity.Property(e => e.ExchangeDate).HasColumnType("date");

                entity.Property(e => e.ExBuyCash).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ExBuyTransfer).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ExSellCash).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ExSellTransfer).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(10)
                    .HasColumnName("InsertUID")
                    .IsFixedLength(true);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(10)
                    .HasColumnName("UpdateUID")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Code });

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Balance)
                    .HasColumnType("decimal(15, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ClassificationId).HasColumnName("ClassificationID");

                entity.Property(e => e.CommercialRegistrationNo).HasMaxLength(50);

                entity.Property(e => e.ContactPerson).HasMaxLength(50);

                entity.Property(e => e.CreditLimit).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.CreditPeriod)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CrexpireDate)
                    .HasColumnType("date")
                    .HasColumnName("CRExpireDate");

                entity.Property(e => e.CurrCode)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.GuranteeChequeAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.GuranteeChequeBank).HasMaxLength(50);

                entity.Property(e => e.GuranteeChequeNo).HasMaxLength(50);

                entity.Property(e => e.IdexpireDate)
                    .HasColumnType("date")
                    .HasColumnName("IDExpireDate");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MailAddress).HasMaxLength(50);

                entity.Property(e => e.MainCustomerId).HasColumnName("MainCustomerID");

                entity.Property(e => e.MainSub).HasMaxLength(1);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(15)
                    .IsFixedLength(true);

                entity.Property(e => e.MrexpireDate)
                    .HasColumnType("date")
                    .HasColumnName("MRExpireDate");

                entity.Property(e => e.MunicipalityApprovalNo).HasMaxLength(50);

                entity.Property(e => e.NameL1).HasMaxLength(200);

                entity.Property(e => e.NameL2).HasMaxLength(200);

                entity.Property(e => e.Nationality).HasMaxLength(50);

                entity.Property(e => e.PaymentMethod)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Pobox)
                    .HasMaxLength(50)
                    .HasColumnName("POBOX");

                entity.Property(e => e.PriceTypeCode)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.RebatePerc).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SalesmanId).HasColumnName("SalesmanID");

                entity.Property(e => e.SponserId)
                    .HasMaxLength(50)
                    .HasColumnName("SponserID");

                entity.Property(e => e.Telephone1).HasMaxLength(200);

                entity.Property(e => e.Telephone2).HasMaxLength(200);

                entity.Property(e => e.TotalCredit)
                    .HasColumnType("decimal(15, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalDebit)
                    .HasColumnType("decimal(15, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<CustomerDiscountsLink>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CustomerDiscountsLink");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DiscountId).HasColumnName("DiscountID");
            });

            modelBuilder.Entity<CustomerProfileDocument>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");
            });

            modelBuilder.Entity<CustomerStatement>(entity =>
            {
                entity.ToTable("CustomerStatement");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Credit).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CusId).HasColumnName("CusID");

                entity.Property(e => e.Debit).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DocumentNo).HasMaxLength(50);

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.TransDate).HasColumnType("date");
            });

            modelBuilder.Entity<CustomerStatementView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CustomerStatement_View");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Cb).HasColumnName("CB");

                entity.Property(e => e.Credit).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CreditLimit).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.CreditPeriod)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength(true);

                entity.Property(e => e.CurrencyName).HasMaxLength(50);

                entity.Property(e => e.CusId).HasColumnName("CusID");

                entity.Property(e => e.CustomerName).HasMaxLength(200);

                entity.Property(e => e.CustomerName2).HasMaxLength(200);

                entity.Property(e => e.Debit).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.Ob).HasColumnName("OB");

                entity.Property(e => e.SalesManId).HasColumnName("SalesManID");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.TransDateBalance).HasColumnType("decimal(38, 3)");

                entity.Property(e => e.TransTypeDesc)
                    .HasMaxLength(18)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomersDiscount>(entity =>
            {
                entity.ToTable("CustomersDiscount");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DiscountPercent).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DiscountValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("insertUID");

                entity.Property(e => e.MaxSalesLimit).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.MinSalesLimit).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidTo).HasColumnType("datetime");
            });

            modelBuilder.Entity<DdColumn>(entity =>
            {
                entity.ToTable("DD_Columns");

                entity.HasIndex(e => new { e.ViewId, e.ColumnId }, "IX_DD_Columns")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ColumnId).HasColumnName("ColumnID");

                entity.Property(e => e.DataType).HasMaxLength(50);
            });

            modelBuilder.Entity<DdGrid>(entity =>
            {
                entity.ToTable("DD_Grid");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FormName).IsRequired();

                entity.Property(e => e.GridName).IsRequired();

                entity.Property(e => e.GridType)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<DdGridUserColumn>(entity =>
            {
                entity.ToTable("DD_GridUserColumns");

                entity.HasIndex(e => new { e.GridId, e.ColumnId, e.ViewId, e.UserCode }, "IX_DD_GridColumns")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ColumnId).HasColumnName("ColumnID");

                entity.Property(e => e.GridId).HasColumnName("GridID");

                entity.Property(e => e.UserCode).HasMaxLength(50);

                entity.Property(e => e.ViewId).HasColumnName("ViewID");

                entity.HasOne(d => d.DdGridView)
                    .WithMany(p => p.DdGridUserColumns)
                    .HasPrincipalKey(p => new { p.GridId, p.ViewId })
                    .HasForeignKey(d => new { d.GridId, d.ViewId })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_DD_GridUserColumns_DD_GridViews");
            });

            modelBuilder.Entity<DdGridView>(entity =>
            {
                entity.ToTable("DD_GridViews");

                entity.HasIndex(e => new { e.GridId, e.ViewId }, "IX_DD_GridViews")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GridId)
                    .IsRequired()
                    .HasColumnName("GridID");

                entity.Property(e => e.ViewId)
                    .IsRequired()
                    .HasColumnName("ViewID");
            });

            modelBuilder.Entity<DdView>(entity =>
            {
                entity.HasKey(e => e.ViewId);

                entity.ToTable("DD_View");

                entity.Property(e => e.ViewId).HasColumnName("ViewID");

                entity.Property(e => e.ViewAbbreviation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ViewName).IsRequired();

                entity.Property(e => e.ViewType)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<DdViewRelation>(entity =>
            {
                entity.ToTable("DD_ViewRelations");

                entity.HasIndex(e => new { e.ViewId1, e.ViewId2 }, "IX_DD_ViewRelations")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ViewId1).HasColumnName("ViewID_1");

                entity.Property(e => e.ViewId2).HasColumnName("ViewID_2");
            });

            modelBuilder.Entity<DeliveryArea>(entity =>
            {
                entity.HasKey(e => e.AreaSerial);

                entity.Property(e => e.AreaSerial).ValueGeneratedNever();

                entity.Property(e => e.AreaCharge).HasColumnType("numeric(15, 3)");

                entity.Property(e => e.AreaName).HasMaxLength(100);
            });

            modelBuilder.Entity<DeliveryDetailsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DeliveryDetails_View");

                entity.Property(e => e.AreaCharge).HasColumnType("numeric(15, 3)");

                entity.Property(e => e.AreaName).HasMaxLength(100);

                entity.Property(e => e.BeforeDiscountPrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.NameL1).IsRequired();

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TerminalId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("TerminalID")
                    .IsFixedLength(true);

                entity.Property(e => e.TrnsQty).HasColumnType("decimal(18, 5)");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeptCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(getdate())", false);

                entity.Property(e => e.NameL1).IsRequired();

                entity.Property(e => e.StoreCode).HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.BranchId)
                    .HasMaxLength(50)
                    .HasColumnName("BranchID");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Credit).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CreditLimit).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Debit).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DiscountPercent).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DiscountValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DiscountValueLimit).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.HourlyRate).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.LastClockIn).HasColumnType("datetime");

                entity.Property(e => e.LastClockOut).HasColumnType("datetime");

                entity.Property(e => e.NationalId).HasColumnName("NationalID");

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.Picture).HasColumnType("image");

                entity.Property(e => e.StatusFlag).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<EndOfdayView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EndOFDay_View");

                entity.Property(e => e.AverageCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Cash).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.CashAmount).HasColumnType("decimal(38, 3)");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.ClosingMonthAverageCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ClosingMonthTotalCost).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.ClosingPeriodAverageCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ClosingPeriodTotalCost).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.CouponAmount).HasColumnType("decimal(38, 3)");

                entity.Property(e => e.Credit).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.CreditCustomerAmount).HasColumnType("decimal(38, 3)");

                entity.Property(e => e.Diff).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.GroupCode).HasMaxLength(3);

                entity.Property(e => e.GroupName).HasMaxLength(200);

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.ItmQty).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ItmValue).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.ModelCode).HasMaxLength(50);

                entity.Property(e => e.OpeningAmount).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PointsAmount).HasColumnType("decimal(38, 3)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StoCode).HasMaxLength(10);

                entity.Property(e => e.TerminalName)
                    .IsRequired()
                    .HasColumnName("Terminal_Name");

                entity.Property(e => e.TotalCost).HasColumnType("decimal(38, 10)");

                entity.Property(e => e.TotalDiscount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TotalDiscountValueForHeader).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.TotalDiscountValueForItem).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.TrnsDate).HasColumnType("date");

                entity.Property(e => e.Visa).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.VisaAmount).HasColumnType("decimal(38, 3)");

                entity.Property(e => e.XAttributeValue).HasColumnName("X_AttributeValue");

                entity.Property(e => e.YAttributeValue).HasColumnName("Y_AttributeValue");
            });

            modelBuilder.Entity<ErpCode>(entity =>
            {
                entity.ToTable("ERP_CODES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CodeTypesId).HasColumnName("CODE_TYPES_ID");

                entity.Property(e => e.CodesSysId).HasColumnName("CODES_SYS_ID");

                entity.Property(e => e.PrimaryName)
                    .HasMaxLength(250)
                    .HasColumnName("PRIMARY_NAME");

                entity.Property(e => e.SecondaryName)
                    .HasMaxLength(250)
                    .HasColumnName("SECONDARY_NAME");

                entity.Property(e => e.UserCode)
                    .HasMaxLength(50)
                    .HasColumnName("USER_CODE");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.EventId).HasColumnName("EventID");
            });

            modelBuilder.Entity<FunctionsPermssion>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");
            });

            modelBuilder.Entity<GljournalDetailsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GLJournalDetails_View");

                entity.Property(e => e.AccountPrimaryName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("ACCOUNT_PRIMARY_NAME");

                entity.Property(e => e.AccountSecondaryName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("ACCOUNT_SECONDARY_NAME");

                entity.Property(e => e.Credit).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Debit).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ErpAccountCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ERP_ACCOUNT_CODE");

                entity.Property(e => e.ErpAccountId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ERP_ACCOUNT_ID");

                entity.Property(e => e.FromToCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("FROM_TO_CODE");

                entity.Property(e => e.FromToDesc).HasColumnName("FROM_TO_DESC");

                entity.Property(e => e.FromToType).HasColumnName("From_To_Type");

                entity.Property(e => e.FromToTypeDesc)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("From_To_Type_Desc");

                entity.Property(e => e.GltransNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("GLTransNo");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.JournalDtlDesc).HasColumnName("JOURNAL_DTL_DESC");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<GljournalHeaderView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GLJournalHeader_View");

                entity.Property(e => e.AccountIntegrationId).HasColumnName("AccountIntegrationID");

                entity.Property(e => e.ComCode).HasMaxLength(10);

                entity.Property(e => e.ConversionRate)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("CONVERSION_RATE");

                entity.Property(e => e.CurrencyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ErpBranchId).HasColumnName("ERP_BRANCH_ID");

                entity.Property(e => e.ErpBranchPrimaryName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("ERP_BRANCH_PRIMARY_NAME");

                entity.Property(e => e.ErpBranchSecondaryName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("ERP_BRANCH_SECONDARY_NAME");

                entity.Property(e => e.ErpCurrencyId).HasColumnName("ERP_CURRENCY_ID");

                entity.Property(e => e.ErpDepartmentPrimaryName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("ERP_DEPARTMENT_PRIMARY_NAME");

                entity.Property(e => e.ErpDepartmentSecondaryName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("ERP_DEPARTMENT_SECONDARY_NAME");

                entity.Property(e => e.ErpDepatmentId).HasColumnName("ERP_DEPATMENT_ID");

                entity.Property(e => e.ErpDoceumentTypeId).HasColumnName("ERP_DOCEUMENT_TYPE_ID");

                entity.Property(e => e.ErpJournalPrimaryName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("ERP_JOURNAL_PRIMARY_NAME");

                entity.Property(e => e.ErpJournalSecondaryName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("ERP_JOURNAL_SECONDARY_NAME");

                entity.Property(e => e.ErpJournalTypeId).HasColumnName("ERP_JOURNAL_TYPE_ID");

                entity.Property(e => e.GlDate)
                    .HasColumnType("date")
                    .HasColumnName("GL_DATE");

                entity.Property(e => e.GltransNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("GLTransNo");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.JournalHdrDesc).HasColumnName("JOURNAL_HDR_DESC");

                entity.Property(e => e.NameL1).IsRequired();

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.PostFlagDesc)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<GljournalsDetail>(entity =>
            {
                entity.HasKey(e => new { e.GltransNo, e.LineSerial });

                entity.ToTable("GLJournalsDetails");

                entity.Property(e => e.GltransNo)
                    .HasMaxLength(50)
                    .HasColumnName("GLTransNo");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.ComCode).HasMaxLength(50);

                entity.Property(e => e.DebitCredit)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("DEBIT_CREDIT");

                entity.Property(e => e.ErpAccountCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ERP_ACCOUNT_CODE");

                entity.Property(e => e.ErpAccountId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ERP_ACCOUNT_ID");

                entity.Property(e => e.FromToCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("FROM_TO_CODE");

                entity.Property(e => e.FromToType).HasColumnName("From_To_Type");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.JournalDtlDesc).HasColumnName("JOURNAL_DTL_DESC");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<GljournalsHeader>(entity =>
            {
                entity.HasKey(e => e.GltransNo);

                entity.ToTable("GLJournalsHeader");

                entity.Property(e => e.GltransNo)
                    .HasMaxLength(50)
                    .HasColumnName("GLTransNo");

                entity.Property(e => e.AccountIntegrationId).HasColumnName("AccountIntegrationID");

                entity.Property(e => e.ComCode).HasMaxLength(10);

                entity.Property(e => e.ConversionRate)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("CONVERSION_RATE");

                entity.Property(e => e.ErpBranchId).HasColumnName("ERP_BRANCH_ID");

                entity.Property(e => e.ErpCurrencyId).HasColumnName("ERP_CURRENCY_ID");

                entity.Property(e => e.ErpDepatmentId).HasColumnName("ERP_DEPATMENT_ID");

                entity.Property(e => e.ErpDoceumentTypeId).HasColumnName("ERP_DOCEUMENT_TYPE_ID");

                entity.Property(e => e.ErpJournalTypeId).HasColumnName("ERP_JOURNAL_TYPE_ID");

                entity.Property(e => e.GlDate)
                    .HasColumnType("date")
                    .HasColumnName("GL_DATE");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.JournalHdrDesc).HasColumnName("JOURNAL_HDR_DESC");

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<GridDescriptionView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GridDescription_View");

                entity.Property(e => e.ColumnDescription).IsRequired();

                entity.Property(e => e.ColumnId).HasColumnName("ColumnID");

                entity.Property(e => e.ColumnName).IsRequired();

                entity.Property(e => e.DataType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormName).IsRequired();

                entity.Property(e => e.GridId).HasColumnName("GridID");

                entity.Property(e => e.GridName).IsRequired();

                entity.Property(e => e.GridType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.UserCode).HasMaxLength(50);

                entity.Property(e => e.ViewAbbreviation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ViewDescription).IsRequired();

                entity.Property(e => e.ViewId).HasColumnName("ViewID");

                entity.Property(e => e.ViewName).IsRequired();

                entity.Property(e => e.ViewType)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<HourlySalesReportView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("HourlySalesReport_VIEW");

                entity.Property(e => e.Avgbill)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("AVGbill");

                entity.Property(e => e.AwayRevenue).HasColumnType("decimal(38, 3)");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("DATE");

                entity.Property(e => e.DineRevenue).HasColumnType("decimal(38, 3)");

                entity.Property(e => e.Hour)
                    .HasMaxLength(13)
                    .HasColumnName("HOUR");

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(38, 3)")
                    .HasColumnName("TOTAL");
            });

            modelBuilder.Entity<InsuranceCompany>(entity =>
            {
                entity.HasKey(e => e.IncId)
                    .HasName("PK_Insurance_Companies");

                entity.Property(e => e.IncId).HasColumnName("INC_ID");

                entity.Property(e => e.IncAddress1).HasColumnName("INC_Address_1");

                entity.Property(e => e.IncAddress2).HasColumnName("INC_Address_2");

                entity.Property(e => e.IncCode)
                    .HasMaxLength(50)
                    .HasColumnName("INC_CODE");

                entity.Property(e => e.IncCountry)
                    .HasMaxLength(50)
                    .HasColumnName("INC_Country");

                entity.Property(e => e.IncCreditCustomerId).HasColumnName("INC_Credit_Customer_ID");

                entity.Property(e => e.IncInsertedBy)
                    .HasMaxLength(50)
                    .HasColumnName("INC_Inserted_By");

                entity.Property(e => e.IncInsertedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("INC_Inserted_Date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IncNameL1)
                    .IsRequired()
                    .HasColumnName("INC_NameL1");

                entity.Property(e => e.IncNameL2).HasColumnName("INC_NameL2");

                entity.Property(e => e.IncPhone1)
                    .HasMaxLength(50)
                    .HasColumnName("INC_Phone_1");

                entity.Property(e => e.IncPhone2)
                    .HasMaxLength(50)
                    .HasColumnName("INC_Phone_2");

                entity.Property(e => e.IncReportDesign)
                    .HasColumnType("xml")
                    .HasColumnName("INC_Report_Design");

                entity.Property(e => e.IncUpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("INC_Updated_By");

                entity.Property(e => e.IncUpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("INC_Updated_Date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<InsuranceCompanyAttribute>(entity =>
            {
                entity.HasKey(e => e.AttributeId);

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.DataType).HasComment("0 ==> List Of Values, 1 == > DateTime, 2 ==> nvarchar, 3 ==> bit, 4 ==> int, 5 ==> decimal");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.InsuranceCompanyId).HasColumnName("InsuranceCompanyID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<InsuranceCompanyAttributeValue>(entity =>
            {
                entity.HasKey(e => e.AttributeValueId);

                entity.Property(e => e.AttributeValueId).HasColumnName("AttributeValueID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<InsuranceInvoiceAttributeDetail>(entity =>
            {
                entity.HasKey(e => new { e.InvoiceRefNo, e.InsuranceAttributeId });

                entity.Property(e => e.InvoiceRefNo).HasMaxLength(50);

                entity.Property(e => e.InsuranceAttributeId).HasColumnName("InsuranceAttributeID");

                entity.Property(e => e.InsuranceAttributeValueId).HasColumnName("InsuranceAttributeValueID");
            });

            modelBuilder.Entity<InsuranceInvoiceDetail>(entity =>
            {
                entity.HasKey(e => e.InvoiceRefNo);

                entity.Property(e => e.InvoiceRefNo).HasMaxLength(50);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.InsuranceCompanyAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.InsuranceCompanyId).HasColumnName("InsuranceCompanyID");

                entity.Property(e => e.InsurancePlanId).HasColumnName("InsurancePlanID");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");
            });

            modelBuilder.Entity<InsurancePlanDetail>(entity =>
            {
                entity.HasKey(e => new { e.PlanHeaderId, e.LineSerial });

                entity.Property(e => e.PlanHeaderId).HasColumnName("PlanHeaderID");

                entity.Property(e => e.RulePercent).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.RuleType).HasComment("0 ==> Group, 1 ==> Category, 2 ==> Model");

                entity.Property(e => e.RuleTypeCode).HasMaxLength(50);
            });

            modelBuilder.Entity<InsurancePlaneHeader>(entity =>
            {
                entity.HasKey(e => e.PlanHeaderId);

                entity.ToTable("InsurancePlaneHeader");

                entity.Property(e => e.PlanHeaderId).HasColumnName("PlanHeaderID");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsuranceCompanyId).HasColumnName("InsuranceCompanyID");

                entity.Property(e => e.PlanCode).HasMaxLength(50);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<InventoryTransactionType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(getdate())", false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TypeName).IsRequired();

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<InvoicePayment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BeneficiaryId).HasColumnName("BeneficiaryID");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.InvAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.InvoiceTransNo).HasMaxLength(50);

                entity.Property(e => e.PvtransNo)
                    .HasMaxLength(50)
                    .HasColumnName("PVTransNo");

                entity.Property(e => e.TransTypeCodeLevel1).HasMaxLength(50);

                entity.Property(e => e.TransTypeCodeLevel2).HasMaxLength(50);
            });

            modelBuilder.Entity<IssueCardsPayment>(entity =>
            {
                entity.HasKey(e => new { e.TransNo, e.TerminalId, e.ShiftId, e.CardId, e.CardNo, e.IssuePaymentId });

                entity.Property(e => e.TransNo).HasMaxLength(50);

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CardNo).HasMaxLength(250);

                entity.Property(e => e.IssuePaymentId)
                    .HasColumnName("IssuePaymentID")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.AmountAfterPercent).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BankValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CardExpiry).HasColumnType("date");

                entity.Property(e => e.CardPercent).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<IssuePayment>(entity =>
            {
                entity.HasKey(e => new { e.TransNo, e.TerminalId, e.StoCode, e.PayType, e.PaidAmount, e.PaymentDate, e.InsertDate, e.TransTerminalId });

                entity.Property(e => e.TransNo).HasMaxLength(50);

                entity.Property(e => e.StoCode).HasMaxLength(10);

                entity.Property(e => e.PayType).HasComment("1=cash;2=visa;3=creditsales;4=copoun;5=loyality;6=cheque");

                entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.TransTerminalId).HasColumnName("TransTerminalID");

                entity.Property(e => e.ComCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.PaidAmountinBase).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<IssueTransHeader>(entity =>
            {
                entity.HasKey(e => new { e.ComCode, e.StoCode, e.SalesTrnsId, e.TerminalId });

                entity.ToTable("IssueTransHeader");

                entity.HasIndex(e => e.SalesTrnsId, "IX_IssueTransHeader_1");

                entity.HasIndex(e => e.SalesType, "IX_IssueTransHeader_2");

                entity.HasIndex(e => e.ShiftId, "IX_IssueTransHeader_3");

                entity.Property(e => e.ComCode).HasMaxLength(50);

                entity.Property(e => e.StoCode).HasMaxLength(50);

                entity.Property(e => e.SalesTrnsId).HasMaxLength(50);

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.AdjustmentAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CashAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ComplementaryFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.CouponAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CouponNo).HasMaxLength(50);

                entity.Property(e => e.CourierId)
                    .HasColumnName("CourierID")
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 ==> Self Delivery, Else Courier ID");

                entity.Property(e => e.CreditCardExpiry).HasColumnType("date");

                entity.Property(e => e.CreditCardNo).HasMaxLength(50);

                entity.Property(e => e.CreditCustomerAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CurrencyCode).HasMaxLength(50);

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.DeliveryCharge).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DeliveryChargeType)
                    .HasDefaultValueSql("((-1))")
                    .HasComment("-1 ==> None, 0 ==> Value, 1 ==> Percentage");

                entity.Property(e => e.DeliveryChargeValue)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeliveryPaymentType).HasDefaultValueSql("((0))");

                entity.Property(e => e.DiscountPercent).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DiscountType)
                    .HasDefaultValueSql("((0))")
                    .HasComment("-1 ==> None, 0 ==> Value, 1 ==> Percentage");

                entity.Property(e => e.DiscountValue)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.GrossAmount)
                    .HasColumnType("decimal(18, 3)")
                    .HasComment("Total Items Value After Discount Per Items And Before Taxes per items");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid).HasMaxLength(50);

                entity.Property(e => e.IssueDropped)
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.Property(e => e.IssueType)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.MarkComId).HasColumnName("MarkComID");

                entity.Property(e => e.MinimumChargeAmount)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.OrigSalesTrnsId)
                    .HasMaxLength(50)
                    .HasColumnName("OrigSalesTrnsID");

                entity.Property(e => e.OtherCost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PhoneNo).HasMaxLength(50);

                entity.Property(e => e.PointsAmount)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.PostFlag)
                    .HasMaxLength(1)
                    .IsFixedLength(true)
                    .HasComment("0 ==> Holded, 1 ==> Posted, 2 ==> Canceled, 3 ==> Layby, 9 ==> Ordering");

                entity.Property(e => e.ReturnTransId).HasMaxLength(50);

                entity.Property(e => e.SaleMid).HasColumnName("SaleMID");

                entity.Property(e => e.SalesType)
                    .HasMaxLength(2)
                    .IsFixedLength(true);

                entity.Property(e => e.ServiceChargeAmount)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ServiceChargePercent).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ServiceChargeType)
                    .HasDefaultValueSql("((-1))")
                    .HasComment("-1 ==> None, 0 ==> Value, 1 ==> Percentage");

                entity.Property(e => e.ServiceChargeValue)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxPercent).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TaxType)
                    .HasDefaultValueSql("((-1))")
                    .HasComment("-1 ==> None, 0 ==> Value, 1 ==> Percentage");

                entity.Property(e => e.TaxValue)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TempTrnsId).HasMaxLength(50);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TotalDiscount)
                    .HasColumnType("decimal(18, 3)")
                    .HasComment("Header Discount Amount");

                entity.Property(e => e.TotalItemsDiscount)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Total Items Discount");

                entity.Property(e => e.TotalItemsTaxes)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Total Items Taxes");

                entity.Property(e => e.TotalTaxs)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Header Taxes Amount");

                entity.Property(e => e.TransType1).HasMaxLength(2);

                entity.Property(e => e.TransType2).HasMaxLength(2);

                entity.Property(e => e.TransUserNo).HasMaxLength(50);

                entity.Property(e => e.TrnsDate).HasColumnType("date");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid).HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VisaAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.WithHoldingTax)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WithHoldingTaxPercent)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Year)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<IssueTransItem>(entity =>
            {
                entity.HasKey(e => new { e.ComCode, e.StoCode, e.TransSerial, e.IssItmSerial, e.TerminalId });

                entity.HasIndex(e => e.TransSerial, "IX_IssueTransItems_1");

                entity.Property(e => e.ComCode).HasMaxLength(50);

                entity.Property(e => e.StoCode).HasMaxLength(50);

                entity.Property(e => e.TransSerial).HasMaxLength(50);

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(10)
                    .HasColumnName("TerminalID")
                    .IsFixedLength(true);

                entity.Property(e => e.AddOnsUnitPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.AverageCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.BeforeDiscountPrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.DeliveryChargeFromHeader)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("DeliveryChargeFromHeader Per Qty ==> 1, Not Total DeliveryChargeFromHeader");

                entity.Property(e => e.DiscountItemType)
                    .HasDefaultValueSql("((-1))")
                    .HasComment("-1 ==> None, 0 ==> Value, 1 ==> Percentage");

                entity.Property(e => e.DiscountItemValue)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiscountValueForHeader)
                    .HasColumnType("decimal(18, 5)")
                    .HasComment("DiscountValueForHeader Per Qty ==> 1, Not Total DiscountValueForHeader");

                entity.Property(e => e.DiscountValueForItem)
                    .HasColumnType("decimal(18, 5)")
                    .HasComment("DiscountValueForItem Per Qty ==> 1, Not Total DiscountValueForItem");

                entity.Property(e => e.InsertDate).HasColumnType("date");

                entity.Property(e => e.InsertUid).HasMaxLength(50);

                entity.Property(e => e.KitchenId).HasColumnName("KitchenID");

                entity.Property(e => e.NextBalance).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.OfferId).HasColumnName("OfferID");

                entity.Property(e => e.PrevBalance).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.PriceFlag)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.ReturnQty).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.SalesManSerial)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.SalesType)
                    .HasMaxLength(2)
                    .IsFixedLength(true);

                entity.Property(e => e.SalestaxValue)
                    .HasColumnType("decimal(18, 5)")
                    .HasComment("Tax Per Qty ==> 1, Not Total Tax");

                entity.Property(e => e.ServiceChargeFromHeader)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("ServiceChargeFromHeader Per Qty ==> 1, Not Total ServiceChargeFromHeader");

                entity.Property(e => e.TableId).HasColumnName("TableID");

                entity.Property(e => e.TaxFromHeader)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TaxFromHeader Per Qty ==> 1, Not Total TaxFromHeader");

                entity.Property(e => e.TaxType)
                    .HasDefaultValueSql("((-1))")
                    .HasComment("-1 ==> None, 0 ==> Value, 1 ==> Percentage");

                entity.Property(e => e.TaxValue)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransType1).HasMaxLength(50);

                entity.Property(e => e.TransType2).HasMaxLength(50);

                entity.Property(e => e.TrnsQty).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.UnitId)
                    .HasMaxLength(10)
                    .HasColumnName("UnitID")
                    .IsFixedLength(true);

                entity.Property(e => e.UnitSalesPrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.UnitType).HasMaxLength(10);

                entity.Property(e => e.UpdateDate).HasColumnType("date");

                entity.Property(e => e.UpdateUid).HasMaxLength(50);

                entity.Property(e => e.WithHoldingTaxFromHeader)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("WithHoldingTaxFromHeader Per Qty ==> 1, Not Total WithHoldingTaxFromHeader");

                entity.Property(e => e.Year)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<IssueTransItemGuest>(entity =>
            {
                entity.HasKey(e => new { e.ComCode, e.StoCode, e.TransSerial, e.LineSerial, e.TerminalId, e.ItmSerial, e.GuestNo });

                entity.ToTable("IssueTransItemGuest");

                entity.Property(e => e.ComCode).HasMaxLength(50);

                entity.Property(e => e.StoCode).HasMaxLength(50);

                entity.Property(e => e.TransSerial).HasMaxLength(50);

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.AddOnsUnitSalesPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.AverageCost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DiscountValueForItem).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.SalesType).HasMaxLength(50);

                entity.Property(e => e.TransType1).HasMaxLength(50);

                entity.Property(e => e.TransType2).HasMaxLength(50);

                entity.Property(e => e.TrnsQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UnitId)
                    .HasMaxLength(50)
                    .HasColumnName("UnitID");

                entity.Property(e => e.UnitSalesPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<IssueTransItemsAddOn>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddOnsQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.AddOnsRecipeQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.AddOnsRecipeUnitId).HasColumnName("AddOnsRecipeUnitID");

                entity.Property(e => e.AddOnsSalesPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.AddOnsTotalPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ComCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid).HasMaxLength(50);

                entity.Property(e => e.LevelId).HasColumnName("LevelID");

                entity.Property(e => e.MainQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.MainUnitCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RefrencedId).HasColumnName("RefrencedID");

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.TransNo).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid).HasMaxLength(50);
            });

            modelBuilder.Entity<IssueTransSplitted>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IssueTransSplitted");

                entity.Property(e => e.OrigSalesTrnsId)
                    .HasMaxLength(50)
                    .HasColumnName("OrigSalesTrnsID");

                entity.Property(e => e.SpltSalestrnsId)
                    .HasMaxLength(50)
                    .HasColumnName("SpltSalestrnsID");
            });

            modelBuilder.Entity<IssueTransactionType>(entity =>
            {
                entity.ToTable("IssueTransactionType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(getdate())", false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<ItemAttributesValuesView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ItemAttributesValues_View");

                entity.Property(e => e.Color).HasColumnName("COLOR");

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.ModelCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModelDescription).IsRequired();

                entity.Property(e => e.Size).HasColumnName("SIZE");
            });

            modelBuilder.Entity<ItemAverageCost>(entity =>
            {
                entity.ToTable("ItemAverageCost");

                entity.HasIndex(e => new { e.ItmSerial, e.FromDate }, "IX_ItemAverageCost")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AverageCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.LastBasePurchasePrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LastPurchasePrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PrevAverageCost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PrevSalesPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.SalesPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<ItemAverageLandedCost>(entity =>
            {
                entity.ToTable("ItemAverageLandedCost");

                entity.HasIndex(e => new { e.ItmSerial, e.FromDate }, "IX_ItemAvgLandedCost")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AvgLandedCost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.LastBasePurchasePrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LastPurchasePrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PrevAvgLandedCost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<ItemBalanceAndCostAtMomentView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ItemBalanceAndCostAtMoment_View");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryNameL1).IsRequired();

                entity.Property(e => e.GroupCode).HasMaxLength(3);

                entity.Property(e => e.GroupNameL1)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ItemNameL1).IsRequired();

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.ModelCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SalesUnitNameL1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.XAttributeValue)
                    .IsRequired()
                    .HasColumnName("X_AttributeValue");

                entity.Property(e => e.YAttributeValue)
                    .IsRequired()
                    .HasColumnName("Y_AttributeValue");
            });

            modelBuilder.Entity<ItemBalanceAndPricesInStoreView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ItemBalanceAndPricesInStore_View");

                entity.Property(e => e.CurrentBalanceIn101)
                    .IsRequired()
                    .HasColumnName("Current Balance In 101");

                entity.Property(e => e.CurrentBalanceIn102)
                    .IsRequired()
                    .HasColumnName("Current Balance In 102");

                entity.Property(e => e.CurrentBalanceIn103)
                    .IsRequired()
                    .HasColumnName("Current Balance In 103");

                entity.Property(e => e.CurrentBalanceIn201)
                    .IsRequired()
                    .HasColumnName("Current Balance In 201");

                entity.Property(e => e.CurrentBalanceIn301)
                    .IsRequired()
                    .HasColumnName("Current Balance In 301");

                entity.Property(e => e.CurrentBalanceIn998)
                    .IsRequired()
                    .HasColumnName("Current Balance In 998");

                entity.Property(e => e.CurrentBalanceIn999)
                    .IsRequired()
                    .HasColumnName("Current Balance In 999");

                entity.Property(e => e.CurrentBalanceInMainKitchen)
                    .IsRequired()
                    .HasColumnName("Current Balance In Main Kitchen");

                entity.Property(e => e.CurrentBalanceInMainStore)
                    .IsRequired()
                    .HasColumnName("Current Balance In Main Store");

                entity.Property(e => e.CurrentBalanceInOutlet1)
                    .IsRequired()
                    .HasColumnName("Current Balance In Outlet 1");

                entity.Property(e => e.CurrentBalanceInOutlet2)
                    .IsRequired()
                    .HasColumnName("Current Balance In Outlet 2");

                entity.Property(e => e.CurrentBalanceInOutlet3)
                    .IsRequired()
                    .HasColumnName("Current Balance In Outlet 3");

                entity.Property(e => e.CurrentBalanceInProductionStore)
                    .IsRequired()
                    .HasColumnName("Current Balance In Production Store");

                entity.Property(e => e.CurrentBalanceInTransferStore)
                    .IsRequired()
                    .HasColumnName("Current Balance In Transfer Store");

                entity.Property(e => e.ItemNameL1).IsRequired();

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.ItmStatusDesc)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LargeSalesPriceIn101)
                    .IsRequired()
                    .HasColumnName("Large Sales Price In 101");

                entity.Property(e => e.LargeSalesPriceIn102)
                    .IsRequired()
                    .HasColumnName("Large Sales Price In 102");

                entity.Property(e => e.LargeSalesPriceIn103)
                    .IsRequired()
                    .HasColumnName("Large Sales Price In 103");

                entity.Property(e => e.LargeSalesPriceIn201)
                    .IsRequired()
                    .HasColumnName("Large Sales Price In 201");

                entity.Property(e => e.LargeSalesPriceIn301)
                    .IsRequired()
                    .HasColumnName("Large Sales Price In 301");

                entity.Property(e => e.LargeSalesPriceInMainKitchen)
                    .IsRequired()
                    .HasColumnName("Large Sales Price In Main Kitchen");

                entity.Property(e => e.LargeSalesPriceInMainStore)
                    .IsRequired()
                    .HasColumnName("Large Sales Price In Main Store");

                entity.Property(e => e.LargeSalesPriceInOutlet1)
                    .IsRequired()
                    .HasColumnName("Large Sales Price In Outlet 1");

                entity.Property(e => e.LargeSalesPriceInOutlet2)
                    .IsRequired()
                    .HasColumnName("Large Sales Price In Outlet 2");

                entity.Property(e => e.LargeSalesPriceInOutlet3)
                    .IsRequired()
                    .HasColumnName("Large Sales Price In Outlet 3");

                entity.Property(e => e.MediumSalesPriceIn101)
                    .IsRequired()
                    .HasColumnName("Medium Sales Price In 101");

                entity.Property(e => e.MediumSalesPriceIn102)
                    .IsRequired()
                    .HasColumnName("Medium Sales Price In 102");

                entity.Property(e => e.MediumSalesPriceIn103)
                    .IsRequired()
                    .HasColumnName("Medium Sales Price In 103");

                entity.Property(e => e.MediumSalesPriceIn201)
                    .IsRequired()
                    .HasColumnName("Medium Sales Price In 201");

                entity.Property(e => e.MediumSalesPriceIn301)
                    .IsRequired()
                    .HasColumnName("Medium Sales Price In 301");

                entity.Property(e => e.MediumSalesPriceInMainKitchen)
                    .IsRequired()
                    .HasColumnName("Medium Sales Price In Main Kitchen");

                entity.Property(e => e.MediumSalesPriceInMainStore)
                    .IsRequired()
                    .HasColumnName("Medium Sales Price In Main Store");

                entity.Property(e => e.MediumSalesPriceInOutlet1)
                    .IsRequired()
                    .HasColumnName("Medium Sales Price In Outlet 1");

                entity.Property(e => e.MediumSalesPriceInOutlet2)
                    .IsRequired()
                    .HasColumnName("Medium Sales Price In Outlet 2");

                entity.Property(e => e.MediumSalesPriceInOutlet3)
                    .IsRequired()
                    .HasColumnName("Medium Sales Price In Outlet 3");

                entity.Property(e => e.ReorderPointIn101)
                    .IsRequired()
                    .HasColumnName("Reorder Point In 101");

                entity.Property(e => e.ReorderPointIn102)
                    .IsRequired()
                    .HasColumnName("Reorder Point In 102");

                entity.Property(e => e.ReorderPointIn103)
                    .IsRequired()
                    .HasColumnName("Reorder Point In 103");

                entity.Property(e => e.ReorderPointIn201)
                    .IsRequired()
                    .HasColumnName("Reorder Point In 201");

                entity.Property(e => e.ReorderPointIn301)
                    .IsRequired()
                    .HasColumnName("Reorder Point In 301");

                entity.Property(e => e.ReorderPointIn998)
                    .IsRequired()
                    .HasColumnName("Reorder Point In 998");

                entity.Property(e => e.ReorderPointIn999)
                    .IsRequired()
                    .HasColumnName("Reorder Point In 999");

                entity.Property(e => e.ReorderPointInMainKitchen)
                    .IsRequired()
                    .HasColumnName("Reorder Point In Main Kitchen");

                entity.Property(e => e.ReorderPointInMainStore)
                    .IsRequired()
                    .HasColumnName("Reorder Point In Main Store");

                entity.Property(e => e.ReorderPointInOutlet1)
                    .IsRequired()
                    .HasColumnName("Reorder Point In Outlet 1");

                entity.Property(e => e.ReorderPointInOutlet2)
                    .IsRequired()
                    .HasColumnName("Reorder Point In Outlet 2");

                entity.Property(e => e.ReorderPointInOutlet3)
                    .IsRequired()
                    .HasColumnName("Reorder Point In Outlet 3");

                entity.Property(e => e.ReorderPointInProductionStore)
                    .IsRequired()
                    .HasColumnName("Reorder Point In Production Store");

                entity.Property(e => e.ReorderPointInTransferStore)
                    .IsRequired()
                    .HasColumnName("Reorder Point In Transfer Store");

                entity.Property(e => e.SmallSalesPriceIn101)
                    .IsRequired()
                    .HasColumnName("Small Sales Price In 101");

                entity.Property(e => e.SmallSalesPriceIn102)
                    .IsRequired()
                    .HasColumnName("Small Sales Price In 102");

                entity.Property(e => e.SmallSalesPriceIn103)
                    .IsRequired()
                    .HasColumnName("Small Sales Price In 103");

                entity.Property(e => e.SmallSalesPriceIn201)
                    .IsRequired()
                    .HasColumnName("Small Sales Price In 201");

                entity.Property(e => e.SmallSalesPriceIn301)
                    .IsRequired()
                    .HasColumnName("Small Sales Price In 301");

                entity.Property(e => e.SmallSalesPriceInMainKitchen)
                    .IsRequired()
                    .HasColumnName("Small Sales Price In Main Kitchen");

                entity.Property(e => e.SmallSalesPriceInMainStore)
                    .IsRequired()
                    .HasColumnName("Small Sales Price In Main Store");

                entity.Property(e => e.SmallSalesPriceInOutlet1)
                    .IsRequired()
                    .HasColumnName("Small Sales Price In Outlet 1");

                entity.Property(e => e.SmallSalesPriceInOutlet2)
                    .IsRequired()
                    .HasColumnName("Small Sales Price In Outlet 2");

                entity.Property(e => e.SmallSalesPriceInOutlet3)
                    .IsRequired()
                    .HasColumnName("Small Sales Price In Outlet 3");
            });

            modelBuilder.Entity<ItemBalanceInStoresView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ItemBalanceInStores_View");

                entity.Property(e => e.LargeBalance).HasMaxLength(102);

                entity.Property(e => e.MainSub).HasMaxLength(1);

                entity.Property(e => e.MeduimBalance).HasMaxLength(102);

                entity.Property(e => e.PurchaseBalance).HasMaxLength(102);

                entity.Property(e => e.SmallBalance).HasMaxLength(102);

                entity.Property(e => e.StoreName)
                    .IsRequired()
                    .HasColumnName("Store Name");
            });

            modelBuilder.Entity<ItemCodeGeneration>(entity =>
            {
                entity.ToTable("ItemCodeGeneration");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasDefaultValueSql("((0))");

                entity.Property(e => e.Length).HasDefaultValueSql("((9999))");

                entity.Property(e => e.OrderNo).HasDefaultValueSql("((9999))");

                entity.Property(e => e.SubstringLayout)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("('LTR')")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ItemColor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ItemColor");

                entity.Property(e => e.ColorCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ColorId).HasColumnName("ColorID");
            });

            modelBuilder.Entity<ItemCompanyPrice>(entity =>
            {
                entity.HasKey(e => e.Icpserial)
                    .HasName("PK_ItemCompanytPrice");

                entity.ToTable("ItemCompanyPrice");

                entity.Property(e => e.Icpserial)
                    .ValueGeneratedNever()
                    .HasColumnName("ICPSerial");

                entity.Property(e => e.ApplyPriceDate).HasColumnType("datetime");

                entity.Property(e => e.ComCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DiscountValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Flag)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(getdate())", false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PriceFactor).HasMaxLength(50);

                entity.Property(e => e.PriceType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Remarks).HasComputedColumnSql("((1))", false);

                entity.Property(e => e.SalesTax2).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 3)");

                entity.HasOne(d => d.ItmSerialNavigation)
                    .WithMany(p => p.ItemCompanyPrices)
                    .HasForeignKey(d => d.ItmSerial)
                    .HasConstraintName("FK_ItemCompanytPrice_ItemMaster");
            });

            modelBuilder.Entity<ItemExpiryDatesByRefrence>(entity =>
            {
                entity.ToTable("ItemExpiryDatesByRefrence");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BarCode).HasMaxLength(50);

                entity.Property(e => e.BatchNo).HasMaxLength(50);

                entity.Property(e => e.BonusQty)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ComCode).HasMaxLength(50);

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.StoCode).HasMaxLength(50);

                entity.Property(e => e.TermCode).HasMaxLength(50);

                entity.Property(e => e.TransTypeCodeLeve1).HasMaxLength(10);

                entity.Property(e => e.TransTypeCodeLeve2).HasMaxLength(10);
            });

            modelBuilder.Entity<ItemExpiryDatesTemp>(entity =>
            {
                entity.ToTable("ItemExpiryDatesTemp");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BatchNo).HasMaxLength(50);

                entity.Property(e => e.BonusQty)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ComCode).HasMaxLength(50);

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.StoCode).HasMaxLength(50);

                entity.Property(e => e.TermCode).HasMaxLength(50);

                entity.Property(e => e.TransTypeCodeLeve1).HasMaxLength(10);

                entity.Property(e => e.TransTypeCodeLeve2).HasMaxLength(10);
            });

            modelBuilder.Entity<ItemExpiryDatesTemp2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ItemExpiryDatesTemp2");

                entity.Property(e => e.BatchNo).HasMaxLength(50);

                entity.Property(e => e.ComCode).HasMaxLength(50);

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.StoCode).HasMaxLength(50);

                entity.Property(e => e.TermCode).HasMaxLength(50);

                entity.Property(e => e.TransTypeCodeLeve1).HasMaxLength(10);

                entity.Property(e => e.TransTypeCodeLeve2).HasMaxLength(10);
            });

            modelBuilder.Entity<ItemExpiryInTransfer>(entity =>
            {
                entity.HasKey(e => new { e.Reference, e.LineSerial, e.ExpiryDate, e.BatchNo });

                entity.ToTable("ItemExpiryInTransfer");

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.BatchNo).HasMaxLength(50);

                entity.Property(e => e.Barcode).HasMaxLength(50);

                entity.Property(e => e.ComCode).HasMaxLength(50);

                entity.Property(e => e.FromStoCode).HasMaxLength(50);

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ToStoCode).HasMaxLength(50);
            });

            modelBuilder.Entity<ItemExpiryTempTransactionView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ItemExpiryTempTransaction_View");

                entity.Property(e => e.BonusQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ItemNameL1).IsRequired();

                entity.Property(e => e.SalesUnitNameL1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SmallExpQty).HasColumnType("decimal(38, 3)");

                entity.Property(e => e.TransNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TransQty).HasColumnType("decimal(20, 5)");
            });

            modelBuilder.Entity<ItemGender>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ItemGender");

                entity.Property(e => e.GederId).HasColumnName("GederID");

                entity.Property(e => e.GenderCode).HasMaxLength(10);
            });

            modelBuilder.Entity<ItemGroup>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(getdate())", false);

                entity.Property(e => e.NameL1)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.NameL2).HasMaxLength(200);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tag).HasMaxLength(200);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<ItemInfoView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ItemInfo_View");

                entity.Property(e => e.AllowChangeNameDesc)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AllowEditPriceDesc)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AllowPurchaseDesc)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AllowReturnDesc)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AllowSalesDesc)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AverageCost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryNameL1).IsRequired();

                entity.Property(e => e.CategoryNameL2).IsRequired();

                entity.Property(e => e.CompanyCurrentBalance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DefaultSalesUnit).HasMaxLength(50);

                entity.Property(e => e.DefaultSalesUnitCode).HasMaxLength(10);

                entity.Property(e => e.DefaultSalesUnitNameL1).HasMaxLength(50);

                entity.Property(e => e.DefaultSalesUnitNameL2).HasMaxLength(50);

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DiscountPercent).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ExpireDate).HasMaxLength(50);

                entity.Property(e => e.GroupCode).HasMaxLength(3);

                entity.Property(e => e.GroupNameL1)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.GroupNameL2)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ItemNameL1).IsRequired();

                entity.Property(e => e.ItemNatureDesc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemTypeCode).HasMaxLength(50);

                entity.Property(e => e.ItemTypeCodeDesc)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.ItmCode10).HasMaxLength(50);

                entity.Property(e => e.ItmCode11).HasMaxLength(50);

                entity.Property(e => e.ItmCode12).HasMaxLength(50);

                entity.Property(e => e.ItmCode13).HasMaxLength(50);

                entity.Property(e => e.ItmCode14).HasMaxLength(50);

                entity.Property(e => e.ItmCode15).HasMaxLength(50);

                entity.Property(e => e.ItmCode16).HasMaxLength(50);

                entity.Property(e => e.ItmCode17).HasMaxLength(50);

                entity.Property(e => e.ItmCode18).HasMaxLength(50);

                entity.Property(e => e.ItmCode19).HasMaxLength(50);

                entity.Property(e => e.ItmCode20).HasMaxLength(50);

                entity.Property(e => e.ItmCode8).HasMaxLength(50);

                entity.Property(e => e.ItmCode9).HasMaxLength(50);

                entity.Property(e => e.ItmIsCat).HasMaxLength(1);

                entity.Property(e => e.ItmMarkup).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.ItmPricingType)
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.Property(e => e.ItmPricingTypeDesc)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ItmProfit).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.ItmStatusDesc)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.KitchenId).HasColumnName("KitchenID");

                entity.Property(e => e.KitchenName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.KitchenPrinterName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.LandedCost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LargUnitCode).HasMaxLength(10);

                entity.Property(e => e.LargeUnitNameL1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LargeUnitNameL2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastPurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.LastPurchasePrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LastSalesDate).HasColumnType("datetime");

                entity.Property(e => e.LastSalesPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MajorTime).HasMaxLength(50);

                entity.Property(e => e.MedUnitCode).HasMaxLength(10);

                entity.Property(e => e.MediumUnitNameL1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MediumUnitNameL2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModelCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModelDescription).IsRequired();

                entity.Property(e => e.OfferDefaultPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PriceListDefaultPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PurchaseTaxAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PurchaseTaxPercent).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PurchaseUnitCode).HasMaxLength(10);

                entity.Property(e => e.PurchaseUnitNameL1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PurchaseUnitNameL2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SalesTaxAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SalesTaxPercent).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SalesUnitCode).HasMaxLength(10);

                entity.Property(e => e.SalesUnitNameL1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SalesUnitNameL2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ShowButtonInSalesDesc)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UseAddOnsDesc)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UseExpiryDesc)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UseLinkedItemsDesc)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UseSerialNoDesc)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.Property(e => e.VendorName).IsRequired();

                entity.Property(e => e.XAttributeValue)
                    .IsRequired()
                    .HasColumnName("X_AttributeValue");

                entity.Property(e => e.YAttributeValue)
                    .IsRequired()
                    .HasColumnName("Y_AttributeValue");
            });

            modelBuilder.Entity<ItemMaster>(entity =>
            {
                entity.HasKey(e => e.ItmSerial);

                entity.ToTable("ItemMaster");

                entity.HasIndex(e => e.TypeCode, "IX_ItemMaster_1");

                entity.HasIndex(e => e.TypeCode, "IX_ItemMaster_2");

                entity.HasIndex(e => e.ItmCode, "ItemCodeUniqe_ItemMaster")
                    .IsUnique();

                entity.Property(e => e.ItmSerial).ValueGeneratedNever();

                entity.Property(e => e.AvailableQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.AverageCost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CurrentBalance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DefaultSalesUnit).HasMaxLength(50);

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DiscountPercent).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ExpireDate).HasMaxLength(50);

                entity.Property(e => e.GroupCode).HasMaxLength(3);

                entity.Property(e => e.InOrderQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.ItmCode10).HasMaxLength(50);

                entity.Property(e => e.ItmCode11).HasMaxLength(50);

                entity.Property(e => e.ItmCode12).HasMaxLength(50);

                entity.Property(e => e.ItmCode13).HasMaxLength(50);

                entity.Property(e => e.ItmCode14).HasMaxLength(50);

                entity.Property(e => e.ItmCode15).HasMaxLength(50);

                entity.Property(e => e.ItmCode16).HasMaxLength(50);

                entity.Property(e => e.ItmCode17).HasMaxLength(50);

                entity.Property(e => e.ItmCode18).HasMaxLength(50);

                entity.Property(e => e.ItmCode19).HasMaxLength(50);

                entity.Property(e => e.ItmCode20).HasMaxLength(50);

                entity.Property(e => e.ItmCode8).HasMaxLength(50);

                entity.Property(e => e.ItmCode9).HasMaxLength(50);

                entity.Property(e => e.ItmIsCat).HasMaxLength(1);

                entity.Property(e => e.ItmMarkup)
                    .HasColumnType("numeric(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ItmPricingType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'n')")
                    .IsFixedLength(true);

                entity.Property(e => e.ItmProfit)
                    .HasColumnType("numeric(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KitchenId).HasColumnName("KitchenID");

                entity.Property(e => e.LandedCost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LargUnitCode).HasMaxLength(10);

                entity.Property(e => e.LastPurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.LastPurchasePrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LastSalesDate).HasColumnType("datetime");

                entity.Property(e => e.LastSalesPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MajorTime).HasMaxLength(50);

                entity.Property(e => e.MedUnitCode).HasMaxLength(10);

                entity.Property(e => e.NameL1).IsRequired();

                entity.Property(e => e.OfferDefaultPrice)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PriceListDefaultPrice)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PurchaseTaxAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PurchaseTaxPercent).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PurchaseUnitCode).HasMaxLength(10);

                entity.Property(e => e.QuickSetupItem).HasDefaultValueSql("((0))");

                entity.Property(e => e.SalesTaxAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SalesTaxPercent).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SalesUnitCode).HasMaxLength(10);

                entity.Property(e => e.TypeCode).HasMaxLength(50);

                entity.Property(e => e.UseExpiry).HasDefaultValueSql("((0))");

                entity.Property(e => e.UseSerialNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<ItemMasterFromErp>(entity =>
            {
                entity.HasKey(e => e.ItmSerial);

                entity.ToTable("ItemMaster_FromERP");

                entity.HasIndex(e => e.ItmCode, "ItemCodeUniqe_ItemMastertemp_FromERP")
                    .IsUnique();

                entity.Property(e => e.ItmSerial).ValueGeneratedNever();

                entity.Property(e => e.AllowSales).HasDefaultValueSql("((1))");

                entity.Property(e => e.AverageCost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CurrentBalance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.FactorLargToMed).HasDefaultValueSql("((1))");

                entity.Property(e => e.FactorMedToSmall).HasDefaultValueSql("((1))");

                entity.Property(e => e.FactorPurchaseToSmall).HasDefaultValueSql("((1))");

                entity.Property(e => e.GroupCode).HasMaxLength(10);

                entity.Property(e => e.IsWeightFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.LargUnitCode).HasMaxLength(10);

                entity.Property(e => e.LastSalesPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.MedUnitCode).HasMaxLength(10);

                entity.Property(e => e.NameL1).IsRequired();

                entity.Property(e => e.Nature).HasDefaultValueSql("((0))");

                entity.Property(e => e.SalesUnitCode).HasMaxLength(10);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.TypeCode).HasMaxLength(50);

                entity.Property(e => e.UseExpiry).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ItemMatrixValue>(entity =>
            {
                entity.HasKey(e => e.ItemAttributesId);

                entity.ToTable("ItemMatrixValues");

                entity.HasIndex(e => e.ItmSerial, "IX_ItemMatrixValues_ItmSerial");

                entity.Property(e => e.ItemAttributesId).HasColumnName("ItemAttributesID");

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.AttributeValueId).HasColumnName("AttributeValueID");

                entity.Property(e => e.ModelCode).HasMaxLength(50);

                entity.Property(e => e.ModelId).HasColumnName("ModelID");
            });

            modelBuilder.Entity<ItemMix>(entity =>
            {
                entity.HasKey(e => new { e.MixNo, e.ItmSerial, e.ItmSerial1, e.UnitType });

                entity.ToTable("ItemMix");

                entity.Property(e => e.UnitType)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("('001')");

                entity.Property(e => e.ItmCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ItmPrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ItmQty).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ItmTotalCost).HasColumnType("decimal(18, 5)");
            });

            modelBuilder.Entity<ItemModel>(entity =>
            {
                entity.HasKey(e => e.ModelId);

                entity.ToTable("ItemModel");

                entity.HasIndex(e => e.ModelCode, "IX_ItemModel")
                    .IsUnique();

                entity.Property(e => e.ModelId).HasColumnName("ModelID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.FactorLargToMed).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.FactorMedToSmall).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.FactorPurchaseToSmall).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.GroupCode).HasMaxLength(50);

                entity.Property(e => e.MaxQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.MinQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ModelCode).HasMaxLength(50);

                entity.Property(e => e.ReorderQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SalesPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.XAttributeId).HasColumnName("X_AttributeID");

                entity.Property(e => e.YAttributeId).HasColumnName("Y_AttributeID");
            });

            modelBuilder.Entity<ItemMovementOverCompanyView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ItemMovementOverCompany_View");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryNameL1).IsRequired();

                entity.Property(e => e.DocumentSerial).HasMaxLength(50);

                entity.Property(e => e.GroupCode).HasMaxLength(3);

                entity.Property(e => e.GroupNameL1)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.GroupNameL2)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ItemNameL1).IsRequired();

                entity.Property(e => e.ModelCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NextCompanyBalance).HasColumnType("decimal(21, 3)");

                entity.Property(e => e.OtherStoreCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.OtherStoreName).IsRequired();

                entity.Property(e => e.PrevCompanyBalance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SalesUnitCode).HasMaxLength(10);

                entity.Property(e => e.SalesUnitNameL1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SalesUnitNameL2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StoreCode)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.StoreName).IsRequired();

                entity.Property(e => e.StoreNextBalance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.StorePrevBalance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.TransTypeDesc)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.TrnsQty).HasColumnType("decimal(20, 3)");

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UnitSalesPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.XAttributeValue)
                    .IsRequired()
                    .HasColumnName("X_AttributeValue");

                entity.Property(e => e.YAttributeValue)
                    .IsRequired()
                    .HasColumnName("Y_AttributeValue");
            });

            modelBuilder.Entity<ItemMovementView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ItemMovement_View");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryNameL1).IsRequired();

                entity.Property(e => e.DocumentSerial).HasMaxLength(50);

                entity.Property(e => e.GroupCode).HasMaxLength(3);

                entity.Property(e => e.GroupNameL1)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.GroupNameL2)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ItemNameL1).IsRequired();

                entity.Property(e => e.MainStoCode).HasMaxLength(50);

                entity.Property(e => e.MainStoreName).IsRequired();

                entity.Property(e => e.ModelCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NextBalance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PrevBalance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SalesUnitCode).HasMaxLength(10);

                entity.Property(e => e.SalesUnitNameL1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SalesUnitNameL2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StoreCode).HasMaxLength(10);

                entity.Property(e => e.StoreName).IsRequired();

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.TransTypeDesc)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.TrnsQty).HasColumnType("decimal(20, 3)");

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.UnitSalesPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.XAttributeValue)
                    .IsRequired()
                    .HasColumnName("X_AttributeValue");

                entity.Property(e => e.YAttributeValue)
                    .IsRequired()
                    .HasColumnName("Y_AttributeValue");
            });

            modelBuilder.Entity<ItemPurchaseHistory>(entity =>
            {
                entity.HasKey(e => e.Iphserial);

                entity.ToTable("ItemPurchaseHistory");

                entity.Property(e => e.Iphserial).HasColumnName("IPHSerial");

                entity.Property(e => e.ComCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.IphavgCost)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("IPHAvgCost");

                entity.Property(e => e.IphavgCustoms)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("IPHAvgCustoms");

                entity.Property(e => e.IphavgOthers)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("IPHAvgOthers");

                entity.Property(e => e.IphavgSales)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("IPHAvgSales");

                entity.Property(e => e.Iphyear)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("IPHYear")
                    .IsFixedLength(true);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUid).HasMaxLength(50);

                entity.Property(e => e.VendorId).HasColumnName("VendorID");
            });

            modelBuilder.Entity<ItemSalesPrice>(entity =>
            {
                entity.HasKey(e => e.Ispserial);

                entity.ToTable("ItemSalesPrice");

                entity.HasIndex(e => new { e.StoCode, e.PriceType, e.ItmSerial }, "IX_ItemSalesPrice");

                entity.HasIndex(e => new { e.StoCode, e.ItmSerial, e.PriceType, e.ApplyPriceDate, e.Qty }, "IX_ItemSalesPrice_1");

                entity.HasIndex(e => e.ApplyPriceDate, "IX_ItemSalesPrice_2");

                entity.HasIndex(e => new { e.ItmSerial, e.Flag, e.PriceType, e.ApplyPriceDate, e.Qty }, "IX_ItemSalesPrice_3");

                entity.Property(e => e.Ispserial).HasColumnName("ISPSerial");

                entity.Property(e => e.ApplyPriceDate).HasColumnType("datetime");

                entity.Property(e => e.ComCode)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DiscountValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Flag).HasComment("0 ==> Pending Approval\r\n1 ==> Approved\r\n2 ==> Denied\r\n3 ==> Canceled");

                entity.Property(e => e.InsertDatetime).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(getdate())", false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PriceFactor).HasMaxLength(50);

                entity.Property(e => e.PriceType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ReferenceNo).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasComputedColumnSql("((1))", false);

                entity.Property(e => e.SalesTax2).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.StoCode)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.UpdateDatetime).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 3)");

                entity.HasOne(d => d.ItmSerialNavigation)
                    .WithMany(p => p.ItemSalesPrices)
                    .HasForeignKey(d => d.ItmSerial)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ItemSalesPrice_ItemMaster");
            });

            modelBuilder.Entity<ItemSalesPriceView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ItemSalesPrice_view");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).IsRequired();

                entity.Property(e => e.CurrentBalance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.GroupCode).HasMaxLength(3);

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.ModelCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NameL1).IsRequired();

                entity.Property(e => e.Price).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SalesUnitCode).HasMaxLength(10);

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TypeCode).HasMaxLength(50);

                entity.Property(e => e.UnitName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Xattribute)
                    .IsRequired()
                    .HasColumnName("XAttribute");

                entity.Property(e => e.Yattribute)
                    .IsRequired()
                    .HasColumnName("YAttribute");
            });

            modelBuilder.Entity<ItemSeason>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.SeasonCode).HasMaxLength(10);

                entity.Property(e => e.SeasonId).HasColumnName("SeasonID");
            });

            modelBuilder.Entity<ItemSerialNoAttributeRelation>(entity =>
            {
                entity.HasKey(e => new { e.ItmSerial, e.SerialNoAttributeId });

                entity.ToTable("ItemSerialNoAttributeRelation");

                entity.Property(e => e.SerialNoAttributeId).HasColumnName("SerialNoAttributeID");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.SerialNoAttributeDesc).HasMaxLength(250);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<ItemSerialNoAttributesValue>(entity =>
            {
                entity.HasKey(e => new { e.ItmSerial, e.SerialNo, e.SerialNoAttributeId });

                entity.Property(e => e.SerialNo).HasMaxLength(50);

                entity.Property(e => e.SerialNoAttributeId).HasColumnName("SerialNoAttributeID");

                entity.Property(e => e.SerialNoAttributeDesc).HasMaxLength(250);

                entity.Property(e => e.SerialNoAttributeValueDesc).HasMaxLength(250);

                entity.Property(e => e.SerialNoAttributeValueId).HasColumnName("SerialNoAttributeValueID");
            });

            modelBuilder.Entity<ItemSerialNoAttributesValuesView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ItemSerialNoAttributesValues_View");

                entity.Property(e => e.ComCode).HasMaxLength(50);

                entity.Property(e => e.ItemNameL1).IsRequired();

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.PurchasePrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SerialNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StoCode).HasMaxLength(50);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<ItemSerialNoTemp>(entity =>
            {
                entity.ToTable("ItemSerialNoTemp");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComCode).HasMaxLength(50);

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.SerialNo).HasMaxLength(50);

                entity.Property(e => e.Status).HasComment("0 ==> Composing, 1 ==> Saved");

                entity.Property(e => e.StoCode).HasMaxLength(50);

                entity.Property(e => e.TermCode).HasMaxLength(50);

                entity.Property(e => e.TransTypeCodeLeve1).HasMaxLength(10);

                entity.Property(e => e.TransTypeCodeLeve2).HasMaxLength(10);

                entity.Property(e => e.UnitCost)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ItemSerialNoTempAttributesValue>(entity =>
            {
                entity.HasKey(e => new { e.ItmSntid, e.SerialNoAttributeId })
                    .HasName("PK_ItemSerialNoAttributesTemp");

                entity.Property(e => e.ItmSntid).HasColumnName("ItmSNTID");

                entity.Property(e => e.SerialNoAttributeId).HasColumnName("SerialNoAttributeID");

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.SerialNo).HasMaxLength(50);

                entity.Property(e => e.SerialNoAttributeDesc).HasMaxLength(250);

                entity.Property(e => e.SerialNoAttributeValueDesc).HasMaxLength(250);

                entity.Property(e => e.SerialNoAttributeValueId).HasColumnName("SerialNoAttributeValueID");

                entity.Property(e => e.Status).HasComment("0 ==> Composing, 1 ==> Saved");
            });

            modelBuilder.Entity<ItemSerialNoTempAttributesValuesView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ItemSerialNoTempAttributesValues_View");

                entity.Property(e => e.ComCode).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ItemNameL1).IsRequired();

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.SerialNo).HasMaxLength(50);

                entity.Property(e => e.StoCode).HasMaxLength(50);

                entity.Property(e => e.TermCode).HasMaxLength(50);

                entity.Property(e => e.TransTypeCodeLeve1).HasMaxLength(10);

                entity.Property(e => e.TransTypeCodeLeve2).HasMaxLength(10);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<ItemSerialNoTempView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ItemSerialNoTemp_View");

                entity.Property(e => e.BonusQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ItemNameL1).IsRequired();

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SalesUnitNameL1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TransQty).HasColumnType("decimal(20, 5)");
            });

            modelBuilder.Entity<ItemSerialNoTransaction>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComCode).HasMaxLength(50);

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.SerialNo).HasMaxLength(50);

                entity.Property(e => e.StoCode).HasMaxLength(50);

                entity.Property(e => e.TermCode).HasMaxLength(50);

                entity.Property(e => e.TransTypeCodeLeve1).HasMaxLength(10);

                entity.Property(e => e.TransTypeCodeLeve2).HasMaxLength(10);

                entity.Property(e => e.UnitCost)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ItemSerialNoTransactionInOutView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ItemSerialNoTransactionInOut_View");

                entity.Property(e => e.InOut)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.SerialNo).HasMaxLength(50);

                entity.Property(e => e.StoCode).HasMaxLength(50);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<ItemSerialsNumber>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ItmSerialId).HasColumnName("ItmSerialID");

                entity.Property(e => e.SerialCode).HasMaxLength(50);
            });

            modelBuilder.Entity<ItemSize>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ItemSize");

                entity.Property(e => e.SizeCode).HasMaxLength(10);

                entity.Property(e => e.SizeId).HasColumnName("SizeID");
            });

            modelBuilder.Entity<ItemStatusChange>(entity =>
            {
                entity.HasKey(e => new { e.ItmSerial, e.UpdateDateTime });

                entity.ToTable("ItemStatusChange");

                entity.Property(e => e.UpdateDateTime).HasColumnType("datetime");

                entity.Property(e => e.StoCode).HasMaxLength(50);

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<ItemStoreCompany>(entity =>
            {
                entity.HasKey(e => new { e.ComCode, e.StoCode, e.ItmSerial });

                entity.ToTable("ItemStoreCompany");

                entity.HasIndex(e => e.StoCode, "IX_ItemStoreCompany_1");

                entity.HasIndex(e => e.ItmSerial, "IX_ItemStoreCompany_ItmSerial");

                entity.Property(e => e.ComCode).HasMaxLength(10);

                entity.Property(e => e.StoCode).HasMaxLength(10);

                entity.Property(e => e.AvailableQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.AverageCost).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.AvrConsumptionDay).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.AvrConsumptionMonth).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.AvrConsumptionYear).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.CashDiscount).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.CurrentBalance).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.Discount1).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.Discount2).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.Discount3).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.InOrderQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ItemLocation).HasMaxLength(50);

                entity.Property(e => e.ItmUser)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.LastAddDate).HasColumnType("datetime");

                entity.Property(e => e.LastIssueDate).HasColumnType("datetime");

                entity.Property(e => e.MaxDiscount).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.MaxLimit).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.MinLimit).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.OpenBalance).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.ReorderPoint).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.SafetyStock).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.TaxValue).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.TypeCode)
                    .HasMaxLength(2)
                    .IsFixedLength(true);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ItemStoreDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ItemStoreDetails");

                entity.Property(e => e.AverageCost).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.AvrConsumptionDay).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.AvrConsumptionMonth).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.AvrConsumptionYear).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.CashDiscount).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.ComCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentBalance).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.Discount1).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.Discount2).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.Discount3).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.Expr1)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ItemLocation).HasMaxLength(50);

                entity.Property(e => e.ItmCode).IsRequired();

                entity.Property(e => e.ItmUser)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.LastAddDate).HasColumnType("datetime");

                entity.Property(e => e.LastIssueDate).HasColumnType("datetime");

                entity.Property(e => e.MaxDiscount).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.MaxLimit).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.MinLimit).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.NameL1).IsRequired();

                entity.Property(e => e.OpenBalance).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.ReorderPoint).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.SafetyStock).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.StoName)
                    .IsRequired()
                    .HasColumnName("SToName");

                entity.Property(e => e.TaxValue).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.TypeCode)
                    .HasMaxLength(2)
                    .IsFixedLength(true);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ItemStoreExpiryDataView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ItemStoreExpiryData_View");

                entity.Property(e => e.BarCode).HasMaxLength(50);

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SalesUnitCode).HasMaxLength(3);

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.StoreName).IsRequired();

                entity.Property(e => e.UnitName).HasMaxLength(50);
            });

            modelBuilder.Entity<ItemStoreExpiryDate>(entity =>
            {
                entity.HasKey(e => new { e.ItmSerial, e.StoCode, e.ComCode, e.ExpiryDate, e.BatchNo });

                entity.Property(e => e.StoCode).HasMaxLength(10);

                entity.Property(e => e.ComCode).HasMaxLength(10);

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.BatchNo).HasMaxLength(50);

                entity.Property(e => e.BarCode).HasMaxLength(50);

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<ItemStoreSerialNo>(entity =>
            {
                entity.HasKey(e => new { e.ItmSerial, e.SerialNo });

                entity.Property(e => e.SerialNo).HasMaxLength(50);

                entity.Property(e => e.ComCode).HasMaxLength(50);

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.PurchasePrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.StoCode).HasMaxLength(50);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<ItemStoreSerialNoStockInOutView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ItemStoreSerialNoStockInOut_View");

                entity.Property(e => e.ComCode).HasMaxLength(50);

                entity.Property(e => e.InCost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.InDate).HasColumnType("datetime");

                entity.Property(e => e.InReference).HasMaxLength(50);

                entity.Property(e => e.OutCost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.OutDate).HasColumnType("datetime");

                entity.Property(e => e.OutReference).HasMaxLength(50);

                entity.Property(e => e.SerialNo).HasMaxLength(50);

                entity.Property(e => e.StoCode).HasMaxLength(50);
            });

            modelBuilder.Entity<ItemStoreView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ItemStore_View");

                entity.Property(e => e.ItmCode).IsRequired();

                entity.Property(e => e.NameL1).IsRequired();

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ItemTransactionPicture>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.TerminalId });

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.Picture).HasColumnType("image");
            });

            modelBuilder.Entity<ItemType>(entity =>
            {
                entity.HasKey(e => e.Itcode);

                entity.Property(e => e.Itcode)
                    .HasMaxLength(2)
                    .HasColumnName("ITCode")
                    .IsFixedLength(true);

                entity.Property(e => e.InventoryItem)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.NameL1).IsUnicode(false);

                entity.Property(e => e.NameL2).IsUnicode(false);
            });

            modelBuilder.Entity<ItemUnit>(entity =>
            {
                entity.HasKey(e => e.Iucode)
                    .HasName("PK_ItemUnits_1");

                entity.Property(e => e.Iucode).HasColumnName("IUCode");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(getdate())", false);

                entity.Property(e => e.NameL1).HasMaxLength(50);

                entity.Property(e => e.NameL2).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<ItemUpload>(entity =>
            {
                entity.HasKey(e => e.LineSerial);

                entity.ToTable("ItemUpload");

                entity.Property(e => e.LineSerial).ValueGeneratedNever();

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.DefaultSalesPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.GroupCode).HasMaxLength(3);

                entity.Property(e => e.GroupName).HasMaxLength(200);

                entity.Property(e => e.ItemNameL1).IsRequired();

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.LargUnitCode).HasMaxLength(10);

                entity.Property(e => e.LargeUnitName).HasMaxLength(50);

                entity.Property(e => e.LastPurchasePrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.MedUnitCode).HasMaxLength(10);

                entity.Property(e => e.MedUnitName).HasMaxLength(50);

                entity.Property(e => e.ModelId).HasColumnName("ModelID");

                entity.Property(e => e.OfferDefaultPrice)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PriceListDefaultPrice)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PurchaseTaxAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PurchaseTaxPercent).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PurchaseUnitCode).HasMaxLength(10);

                entity.Property(e => e.PurchaseUnitName).HasMaxLength(50);

                entity.Property(e => e.SalesTaxAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SalesTaxPercent).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SalesUnitCode).HasMaxLength(10);

                entity.Property(e => e.SalesUnitName).HasMaxLength(50);
            });

            modelBuilder.Entity<ItemVendor>(entity =>
            {
                entity.HasKey(e => new { e.VenSerial, e.ItmSerial });

                entity.Property(e => e.LastPurchaseDate).HasColumnType("date");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PurchasePrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<ItemVendorsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ItemVendors_view");

                entity.Property(e => e.BonusQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CurrencyNameL1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.ItemDiscountValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ItmCode)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Piserial)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PISerial");

                entity.Property(e => e.PurchaseUnitName1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.TransQty).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransUnitPrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.VendorNameL1).IsRequired();
            });

            modelBuilder.Entity<ItemsWithUnitsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ItemsWithUnits_View");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryNameL1).IsRequired();

                entity.Property(e => e.GroupCode).HasMaxLength(3);

                entity.Property(e => e.GroupNameL1)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ItemNameL1).IsRequired();

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.ModelCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModelDescription).IsRequired();

                entity.Property(e => e.UnitCode).HasMaxLength(10);

                entity.Property(e => e.UnitName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UnitType)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UnitTypeDesc)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.XAttributeValue)
                    .IsRequired()
                    .HasColumnName("X_AttributeValue");

                entity.Property(e => e.YAttributeValue)
                    .IsRequired()
                    .HasColumnName("Y_AttributeValue");
            });

            modelBuilder.Entity<JournalType>(entity =>
            {
                entity.HasKey(e => e.JournalTypesId);

                entity.ToTable("JOURNAL_TYPES");

                entity.Property(e => e.JournalTypesId)
                    .ValueGeneratedNever()
                    .HasColumnName("JOURNAL_TYPES_ID");

                entity.Property(e => e.PrimaryName)
                    .HasMaxLength(250)
                    .HasColumnName("PRIMARY_NAME");

                entity.Property(e => e.SecondaryName)
                    .HasMaxLength(250)
                    .HasColumnName("SECONDARY_NAME");
            });

            modelBuilder.Entity<Kitchen>(entity =>
            {
                entity.Property(e => e.KitchenId)
                    .ValueGeneratedNever()
                    .HasColumnName("KitchenID");

                entity.Property(e => e.KitchenName).HasMaxLength(200);

                entity.Property(e => e.PrinterName).HasMaxLength(200);

                entity.Property(e => e.UseExternalStockStore).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KitchenOrder>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FinishTime).HasColumnType("datetime");

                entity.Property(e => e.KitchenId).HasColumnName("KitchenID");

                entity.Property(e => e.MajorTime).HasMaxLength(50);

                entity.Property(e => e.OrderTime).HasColumnType("datetime");

                entity.Property(e => e.OrderUser).HasMaxLength(50);

                entity.Property(e => e.ShId).HasColumnName("ShID");

                entity.Property(e => e.StoCode).HasMaxLength(50);

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.TransNo).HasMaxLength(50);

                entity.Property(e => e.TransTypeCodeL1).HasMaxLength(10);

                entity.Property(e => e.TrnsQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<KitchenStore>(entity =>
            {
                entity.HasKey(e => new { e.KitchenId, e.IssueStoCode });

                entity.Property(e => e.KitchenId).HasColumnName("KitchenID");

                entity.Property(e => e.IssueStoCode).HasMaxLength(50);

                entity.Property(e => e.StockStoCode)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Label>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Color).HasMaxLength(50);
            });

            modelBuilder.Entity<LevelsAddOn>(entity =>
            {
                entity.HasKey(e => new { e.LevelId, e.LevelItemSerial });

                entity.Property(e => e.LevelId).HasColumnName("LevelID");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Log");

                entity.Property(e => e.AcId).HasColumnName("AcID");

                entity.Property(e => e.LogEnd).HasColumnType("datetime");

                entity.Property(e => e.LogStart).HasColumnType("datetime");

                entity.Property(e => e.SalesTrnsId)
                    .HasMaxLength(50)
                    .HasColumnName("SalesTrnsID");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<LogAction>(entity =>
            {
                entity.HasKey(e => e.AcId);

                entity.ToTable("log_action");

                entity.Property(e => e.AcId)
                    .ValueGeneratedNever()
                    .HasColumnName("AcID");

                entity.Property(e => e.AcName2).HasMaxLength(50);
            });

            modelBuilder.Entity<LoyaltySetupDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FromPoint).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.HeaderId).HasColumnName("HeaderID");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid).HasColumnName("InsertUID");

                entity.Property(e => e.ToPoint).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<LoyaltySetupHeader>(entity =>
            {
                entity.ToTable("LoyaltySetupHeader");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplyDate).HasColumnType("datetime");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid).HasColumnName("InsertUID");

                entity.Property(e => e.SetupType).HasComment("0 = Add Points Setup ; 1 = Redeem Points Setup");

                entity.Property(e => e.Status).HasComment("Active Or Not");
            });

            modelBuilder.Entity<MarketingCompaniesPeriod>(entity =>
            {
                entity.ToTable("MarketingCompaniesPeriod");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DiscountType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength(true)
                    .HasComment("0 ==> Percent, 1 ==> Value");

                entity.Property(e => e.DiscountValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.MarkComId).HasColumnName("MarkComID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");

                entity.HasOne(d => d.MarkCom)
                    .WithMany(p => p.MarketingCompaniesPeriods)
                    .HasForeignKey(d => d.MarkComId)
                    .HasConstraintName("FK_MarketingCompaniesPeriod_MarketingCompanies");
            });

            modelBuilder.Entity<MarketingCompany>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.NameL1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NameL2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<MastersSerial>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MasterName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MaxSerialsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MaxSerials_View");

                entity.Property(e => e.Module)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.TransTypeCodeLevel1)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ModelAttribute>(entity =>
            {
                entity.HasKey(e => e.AttributeId);

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.AttributeNameL1).HasMaxLength(250);

                entity.Property(e => e.AttributeNameL2).HasMaxLength(250);

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<ModelAttributeValue>(entity =>
            {
                entity.HasKey(e => e.AttributeValueId)
                    .HasName("PK_AttributeValues");

                entity.Property(e => e.AttributeValueId).HasColumnName("AttributeValueID");

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<Nationality>(entity =>
            {
                entity.ToTable("Nationality");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.Nationality1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Nationality");

                entity.Property(e => e.UpdaeUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdaeUID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Object>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ArabName).HasMaxLength(50);

                entity.Property(e => e.EngName).HasMaxLength(50);

                entity.Property(e => e.ObjectName).HasMaxLength(50);
            });

            modelBuilder.Entity<Offer>(entity =>
            {
                entity.Property(e => e.ComCode).HasMaxLength(10);

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate()+(1))");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.ItmCode).HasMaxLength(50);

                entity.Property(e => e.ItmSerial).HasColumnName("itmSerial");

                entity.Property(e => e.OfferQty)
                    .HasColumnType("numeric(18, 5)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Price).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.StoCode).HasMaxLength(10);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<PaymentLineInvoice>(entity =>
            {
                entity.HasKey(e => new { e.PvtransNo, e.PvlineSerial, e.InvoiceTransNo });

                entity.Property(e => e.PvtransNo)
                    .HasMaxLength(50)
                    .HasColumnName("PVTransNo");

                entity.Property(e => e.PvlineSerial).HasColumnName("PVLineSerial");

                entity.Property(e => e.InvoiceTransNo).HasMaxLength(50);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BeneficiaryId).HasColumnName("BeneficiaryID");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.InvAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PvtransType)
                    .HasColumnName("PVTransType")
                    .HasComment("0 = Payment ; 1 = Receipt 2 = Prepayment; 3 = Deposit");

                entity.Property(e => e.TransTypeCodeLevel1).HasMaxLength(50);

                entity.Property(e => e.TransTypeCodeLevel2).HasMaxLength(50);
            });

            modelBuilder.Entity<PaymentType>(entity =>
            {
                entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentTypeID");

                entity.Property(e => e.AccountCode).HasMaxLength(50);

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.CostCenterCode).HasMaxLength(50);

                entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.PaymentType1).HasColumnName("PaymentType");
            });

            modelBuilder.Entity<PaymentVoucherDetailsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PaymentVoucherDetails_View");

                entity.Property(e => e.AccountCode).HasMaxLength(50);

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AccountName).HasMaxLength(250);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BankName).IsRequired();

                entity.Property(e => e.ChequeBankId).HasColumnName("ChequeBankID");

                entity.Property(e => e.ChequeDueDate).HasColumnType("date");

                entity.Property(e => e.ChequeNo).HasMaxLength(50);

                entity.Property(e => e.CostCenterCode).HasMaxLength(50);

                entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");

                entity.Property(e => e.CostCenterName).HasMaxLength(250);

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.PvhtransNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PVHTransNo");
            });

            modelBuilder.Entity<PaymentVoucherHeaderView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PaymentVoucherHeader_View");

                entity.Property(e => e.AccountCode).HasMaxLength(50);

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.BeneficiaryDesc)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiaryId)
                    .HasMaxLength(50)
                    .HasColumnName("BeneficiaryID");

                entity.Property(e => e.ComCode).HasMaxLength(10);

                entity.Property(e => e.CompanyName).IsRequired();

                entity.Property(e => e.CostCenterCode).HasMaxLength(50);

                entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");

                entity.Property(e => e.CurrencyCode).HasMaxLength(10);

                entity.Property(e => e.CurrencyName).HasMaxLength(50);

                entity.Property(e => e.CurrencyXrate)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("CurrencyXRate");

                entity.Property(e => e.DocumentNo).HasMaxLength(50);

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("insertUID");

                entity.Property(e => e.MainSub)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PostFlagDesc)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalesManId).HasColumnName("SalesManID");

                entity.Property(e => e.StoCode).HasMaxLength(10);

                entity.Property(e => e.StoreName).IsRequired();

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TotalAmountinBase).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.TransNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TransTypeDesc)
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PaymentVouchersDetail>(entity =>
            {
                entity.HasKey(e => new { e.ComCode, e.StoCode, e.PvhtransNo, e.LineSerial });

                entity.Property(e => e.ComCode).HasMaxLength(10);

                entity.Property(e => e.StoCode).HasMaxLength(10);

                entity.Property(e => e.PvhtransNo)
                    .HasMaxLength(50)
                    .HasColumnName("PVHTransNo");

                entity.Property(e => e.AccountCode).HasMaxLength(50);

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ChequeBankId).HasColumnName("ChequeBankID");

                entity.Property(e => e.ChequeDueDate).HasColumnType("date");

                entity.Property(e => e.ChequeNo).HasMaxLength(50);

                entity.Property(e => e.CostCenterCode).HasMaxLength(50);

                entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.Pvtype).HasColumnName("PVType");
            });

            modelBuilder.Entity<PaymentVouchersHeader>(entity =>
            {
                entity.HasKey(e => e.TransNo);

                entity.ToTable("PaymentVouchersHeader");

                entity.Property(e => e.TransNo).HasMaxLength(50);

                entity.Property(e => e.AccountCode).HasMaxLength(50);

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.BeneficiaryId)
                    .HasMaxLength(50)
                    .HasColumnName("BeneficiaryID");

                entity.Property(e => e.ComCode).HasMaxLength(10);

                entity.Property(e => e.CostCenterCode).HasMaxLength(50);

                entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");

                entity.Property(e => e.CurrencyCode).HasMaxLength(10);

                entity.Property(e => e.CurrencyXrate)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("CurrencyXRate");

                entity.Property(e => e.DocumentNo).HasMaxLength(50);

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("insertUID");

                entity.Property(e => e.SalesManId).HasColumnName("SalesManID");

                entity.Property(e => e.StoCode).HasMaxLength(10);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TotalAmountinBase).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TransDate).HasColumnType("date");
            });

            modelBuilder.Entity<PriceListAssigning>(entity =>
            {
                entity.ToTable("PriceListAssigning");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplyPriceDate).HasColumnType("datetime");

                entity.Property(e => e.AssignType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AssignTypeCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.PriceListCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<PriceListAssigningTypesView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PriceListAssigningTypes_View");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PriceListDetail>(entity =>
            {
                entity.HasKey(e => new { e.PriceListCode, e.LineSerial });

                entity.Property(e => e.PriceListCode).HasMaxLength(50);

                entity.Property(e => e.ApplyPriceDate).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.MinPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Tax).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UnitType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('001')");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<PriceListHeader>(entity =>
            {
                entity.HasKey(e => e.PriceListCode);

                entity.ToTable("PriceListHeader");

                entity.Property(e => e.PriceListCode).HasMaxLength(50);

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.PriceListName).IsRequired();
            });

            modelBuilder.Entity<Printer>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(getdate())", false);

                entity.Property(e => e.PrinterName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PrinterTag).HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<PromotionDetail>(entity =>
            {
                entity.HasKey(e => e.ProSerial);

                entity.Property(e => e.ProSerial).ValueGeneratedNever();

                entity.Property(e => e.ComCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DiscountPercent).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DiscountValue).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.QtyDiscountLimit).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UpdateFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ValueDiscountLimit).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.ItmSerialNavigation)
                    .WithMany(p => p.PromotionDetails)
                    .HasForeignKey(d => d.ItmSerial)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PromotionDetails_ItemMaster");
            });

            modelBuilder.Entity<PromotionHeader>(entity =>
            {
                entity.HasKey(e => e.ProSerial);

                entity.ToTable("PromotionHeader");

                entity.Property(e => e.ProSerial).ValueGeneratedNever();

                entity.Property(e => e.ComCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PriceType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.StoCode)
                    .HasMaxLength(10)
                    .HasColumnName("StoCOde")
                    .IsFixedLength(true);

                entity.Property(e => e.TypeFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PurchaseInvoiceDetailsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PurchaseInvoiceDetails_View");

                entity.Property(e => e.BonusQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DocumentDiscountValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ExpensesDistributed).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ItemDiscountValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ItmCode)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ItmSalesPrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.NextBalance).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.OtherCostValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Piserial)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PISerial");

                entity.Property(e => e.PreviouseBalance).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.PurchaseUnitCode)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.PurchaseUnitName1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PurchaseUnitName2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RecTransSerial).ValueGeneratedOnAdd();

                entity.Property(e => e.TotalCustomValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalQtyPrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransItmTaxValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransLastPurchasePrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransQty).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransSalesTaxValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransUnitPrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Year)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<PurchaseInvoiceHeaderView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PurchaseInvoiceHeader_View");

                entity.Property(e => e.BaseNetAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BaseTotalDiscountValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BaseTotalItemsValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BaseTotalOthersValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BaseTotalTaxValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ComCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CompanyName1).IsRequired();

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CurrencyNameL1).HasMaxLength(50);

                entity.Property(e => e.CurrencyNameL2).HasMaxLength(50);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Expenses).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDate).HasColumnType("date");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.MainVendorId).HasColumnName("MainVendorID");

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Piserial)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PISerial");

                entity.Property(e => e.Poserial)
                    .HasMaxLength(50)
                    .HasColumnName("POSerial");

                entity.Property(e => e.PostFlag)
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.Property(e => e.PostFlageDesc)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostedBy).HasMaxLength(50);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.PurchaseInvoiceDesc)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.RecievedFlagDesc)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.StoName1).IsRequired();

                entity.Property(e => e.TotalDiscountValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalItemsValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalNoOfItems).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.TotalOthersValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalQty).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.TotalSalesTaxValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalTaxValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");

                entity.Property(e => e.VendorNameL1).IsRequired();
            });

            modelBuilder.Entity<PurchaseInvoicePrintView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PurchaseInvoicePrint_View");

                entity.Property(e => e.BaseNetAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BaseTotalDiscountValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BaseTotalItemsValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BaseTotalOthersValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BatchNo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BonusQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryNameL1).IsRequired();

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CurrencyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DocumentDiscountValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ExpensesValuePerQty).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ExpiryDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GroupCode).HasMaxLength(3);

                entity.Property(e => e.GroupNameL1)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.InvoiceDate).HasColumnType("date");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.ItemDiscountValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ItmInputCode).HasMaxLength(50);

                entity.Property(e => e.ItmSalesPrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.MainVendorCode).HasMaxLength(50);

                entity.Property(e => e.ModelCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModelDescription).IsRequired();

                entity.Property(e => e.NameL1).IsRequired();

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.PostFlag)
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.Property(e => e.PostedBy).HasMaxLength(50);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.StoreName).IsRequired();

                entity.Property(e => e.TotalDiscountValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalItemsValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalQtyPrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalSalesTaxValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalTaxValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.TransItmTaxValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TransQty).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransSalesTaxValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransTypeCodeLevel1)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TransUnitPrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.UnitName).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");

                entity.Property(e => e.XAttributeValue)
                    .IsRequired()
                    .HasColumnName("X_AttributeValue");

                entity.Property(e => e.YAttributeValue)
                    .IsRequired()
                    .HasColumnName("Y_AttributeValue");
            });

            modelBuilder.Entity<PurchaseOrderDetail>(entity =>
            {
                entity.HasKey(e => new { e.ComCode, e.Poserial, e.PodlineSerial });

                entity.Property(e => e.ComCode).HasMaxLength(10);

                entity.Property(e => e.Poserial)
                    .HasMaxLength(50)
                    .HasColumnName("POSerial");

                entity.Property(e => e.PodlineSerial).HasColumnName("PODLineSerial");

                entity.Property(e => e.BonusQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ItemDiscount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ItmSalesPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PoddeliveryDate)
                    .HasColumnType("date")
                    .HasColumnName("PODDeliveryDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PodinsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PODInsertDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PodinsertUid)
                    .HasMaxLength(10)
                    .HasColumnName("PODInsertUID");

                entity.Property(e => e.PodlastPurchasePrice)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PODLastPurchasePrice");

                entity.Property(e => e.PodpurchaseBasePrice)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PODPurchaseBasePrice");

                entity.Property(e => e.PodpurchasePrice)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PODPurchasePrice");

                entity.Property(e => e.PodpurchaseUnit)
                    .HasMaxLength(10)
                    .HasColumnName("PODPurchaseUnit")
                    .IsFixedLength(true);

                entity.Property(e => e.Podqty)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PODQty");

                entity.Property(e => e.Podreceived)
                    .HasColumnName("PODReceived")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PodreceivedQty)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PODReceivedQty");

                entity.Property(e => e.Podremarks)
                    .HasMaxLength(500)
                    .HasColumnName("PODRemarks");

                entity.Property(e => e.PodreturnQty)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PODReturnQty");

                entity.Property(e => e.PodtotalBaseLine)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PODTotalBaseLine");

                entity.Property(e => e.PodtotalLine)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PODTotalLine");

                entity.Property(e => e.PodunitFactor)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PODUnitFactor");

                entity.Property(e => e.PodupdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PODUpdateDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PodupdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("PODUpdateUID");

                entity.Property(e => e.PodvendorSerial).HasColumnName("PODVendorSerial");

                entity.Property(e => e.Podyear).HasColumnName("PODYear");
            });

            modelBuilder.Entity<PurchaseOrderDetailsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PurchaseOrderDetails_View");

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.PodlastPurchasePrice)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PODLastPurchasePrice");

                entity.Property(e => e.PodlineSerial).HasColumnName("PODLineSerial");

                entity.Property(e => e.PodpurchaseBasePrice)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PODPurchaseBasePrice");

                entity.Property(e => e.PodpurchasePrice)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PODPurchasePrice");

                entity.Property(e => e.PodpurchaseUnit)
                    .HasMaxLength(10)
                    .HasColumnName("PODPurchaseUnit")
                    .IsFixedLength(true);

                entity.Property(e => e.Podqty)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PODQty");

                entity.Property(e => e.Podreceived).HasColumnName("PODReceived");

                entity.Property(e => e.PodtotalBaseLine)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PODTotalBaseLine");

                entity.Property(e => e.PodtotalLine)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PODTotalLine");

                entity.Property(e => e.Poserial)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("POSerial");

                entity.Property(e => e.ReceivedQty).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitName).HasMaxLength(50);

                entity.Property(e => e.UnitName2)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PurchaseOrderDetialsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PurchaseOrderDetials_View");

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.PodlastPurchasePrice)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PODLastPurchasePrice");

                entity.Property(e => e.PodlineSerial).HasColumnName("PODLineSerial");

                entity.Property(e => e.PodpurchaseBasePrice)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PODPurchaseBasePrice");

                entity.Property(e => e.PodpurchasePrice)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PODPurchasePrice");

                entity.Property(e => e.PodpurchaseUnit)
                    .HasMaxLength(10)
                    .HasColumnName("PODPurchaseUnit")
                    .IsFixedLength(true);

                entity.Property(e => e.Podqty)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PODQty");

                entity.Property(e => e.Podreceived).HasColumnName("PODReceived");

                entity.Property(e => e.PodtotalBaseLine)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PODTotalBaseLine");

                entity.Property(e => e.PodtotalLine)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PODTotalLine");

                entity.Property(e => e.Poserial)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("POSerial");

                entity.Property(e => e.ReceivedQty).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitName).HasMaxLength(50);

                entity.Property(e => e.UnitName2)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PurchaseOrderHeader>(entity =>
            {
                entity.HasKey(e => new { e.ComCode, e.Poserial, e.Poyear });

                entity.ToTable("PurchaseOrderHeader");

                entity.Property(e => e.ComCode).HasMaxLength(10);

                entity.Property(e => e.Poserial)
                    .HasMaxLength(50)
                    .HasColumnName("POSerial");

                entity.Property(e => e.Poyear).HasColumnName("POYear");

                entity.Property(e => e.BaseCurrencyCode).HasMaxLength(10);

                entity.Property(e => e.BaseOtherExpenses).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BasePototalShippingExpenses)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("BasePOTotalShippingExpenses");

                entity.Property(e => e.BaseTotalTax)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("BaseTotal_Tax");

                entity.Property(e => e.BaseTotalValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CurrencyXrate)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("CurrencyXRate");

                entity.Property(e => e.DeliveryAddress).HasMaxLength(500);

                entity.Property(e => e.ExpectedDeliveryDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PocurrencyCode)
                    .HasMaxLength(10)
                    .HasColumnName("POCurrencyCode");

                entity.Property(e => e.Podate)
                    .HasColumnType("date")
                    .HasColumnName("PODate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PoendDate)
                    .HasColumnType("datetime")
                    .HasColumnName("POEndDate");

                entity.Property(e => e.PoinsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("POInsertDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PoinsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("POInsertUID");

                entity.Property(e => e.PootherExpenses)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("POOtherExpenses");

                entity.Property(e => e.PopaymentType)
                    .HasMaxLength(2)
                    .HasColumnName("POPaymentType");

                entity.Property(e => e.PopostingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("POPostingDate");

                entity.Property(e => e.Poremarks).HasColumnName("PORemarks");

                entity.Property(e => e.PorequestSerial)
                    .HasMaxLength(50)
                    .HasColumnName("PORequestSerial");

                entity.Property(e => e.PostartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("POStartDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Postatus)
                    .HasColumnName("POStatus")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PototalItems).HasColumnName("POTotalItems");

                entity.Property(e => e.PototalShippingExpenses)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("POTotalShippingExpenses");

                entity.Property(e => e.PototalTax)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("POTotal_Tax");

                entity.Property(e => e.PototalValue)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("POTotalValue");

                entity.Property(e => e.PoupdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("POUpdateDate");

                entity.Property(e => e.PoupdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("POUpdateUID");

                entity.Property(e => e.PovenSerial).HasColumnName("POVenSerial");

                entity.Property(e => e.StoCode).HasMaxLength(10);
            });

            modelBuilder.Entity<PurchaseOrderHeaderView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PurchaseOrderHeader_View");

                entity.Property(e => e.ApprovedBy).HasMaxLength(50);

                entity.Property(e => e.ApprovedDateTime).HasMaxLength(50);

                entity.Property(e => e.BaseCurrencyCode).HasMaxLength(10);

                entity.Property(e => e.BaseCurrencyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BaseCurrencyNameL2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BaseOtherExpenses).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BasePototalShippingExpenses)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("BasePOTotalShippingExpenses");

                entity.Property(e => e.BaseTotalTax)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("BaseTotal_Tax");

                entity.Property(e => e.BaseTotalValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ClosedBy).HasMaxLength(50);

                entity.Property(e => e.ClosedDateTime).HasMaxLength(50);

                entity.Property(e => e.ComCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CompanyName1).IsRequired();

                entity.Property(e => e.CompanyName2).IsRequired();

                entity.Property(e => e.DeliveryAddress).HasMaxLength(500);

                entity.Property(e => e.ExpectedDeliveryDate).HasColumnType("date");

                entity.Property(e => e.PoDesc)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.PocurrencyCode)
                    .HasMaxLength(10)
                    .HasColumnName("POCurrencyCode");

                entity.Property(e => e.PocurrencyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("POCurrencyName");

                entity.Property(e => e.PocurrencyNameL2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("POCurrencyNameL2");

                entity.Property(e => e.Podate)
                    .HasColumnType("date")
                    .HasColumnName("PODate");

                entity.Property(e => e.PoendDate)
                    .HasColumnType("datetime")
                    .HasColumnName("POEndDate");

                entity.Property(e => e.PoinsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("POInsertDate");

                entity.Property(e => e.PoinsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("POInsertUID");

                entity.Property(e => e.PootherExpenses)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("POOtherExpenses");

                entity.Property(e => e.PopostingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("POPostingDate");

                entity.Property(e => e.Poremarks).HasColumnName("PORemarks");

                entity.Property(e => e.Poserial)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("POSerial");

                entity.Property(e => e.PostartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("POStartDate");

                entity.Property(e => e.Postatus).HasColumnName("POStatus");

                entity.Property(e => e.PototalItems).HasColumnName("POTotalItems");

                entity.Property(e => e.PototalShippingExpenses)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("POTotalShippingExpenses");

                entity.Property(e => e.PototalTax)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("POTotal_Tax");

                entity.Property(e => e.PototalValue)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("POTotalValue");

                entity.Property(e => e.PoupdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("POUpdateDate");

                entity.Property(e => e.PovenSerial).HasColumnName("POVenSerial");

                entity.Property(e => e.Poyear).HasColumnName("POYear");

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.StoName1).IsRequired();

                entity.Property(e => e.StoName2).IsRequired();

                entity.Property(e => e.VendorName).IsRequired();

                entity.Property(e => e.VendorName2).IsRequired();
            });

            modelBuilder.Entity<PurchaseOrderView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PurchaseOrder_View");

                entity.Property(e => e.ApprovedBy).HasMaxLength(50);

                entity.Property(e => e.ApprovedDateTime).HasMaxLength(50);

                entity.Property(e => e.BaseCurrencyCode).HasMaxLength(10);

                entity.Property(e => e.BaseCurrencyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BaseOtherExpenses).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BasePototalShippingExpenses)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("BasePOTotalShippingExpenses");

                entity.Property(e => e.BaseTotalTax)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("BaseTotal_Tax");

                entity.Property(e => e.BaseTotalValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ClosedBy).HasMaxLength(50);

                entity.Property(e => e.ClosedDateTime).HasMaxLength(50);

                entity.Property(e => e.ComCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CompanyName).IsRequired();

                entity.Property(e => e.DeliveryAddress).HasMaxLength(500);

                entity.Property(e => e.ExpectedDeliveryDate).HasColumnType("date");

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ModelCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PoDesc)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.PocurrencyCode)
                    .HasMaxLength(10)
                    .HasColumnName("POCurrencyCode");

                entity.Property(e => e.PocurrencyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("POCurrencyName");

                entity.Property(e => e.Podate)
                    .HasColumnType("date")
                    .HasColumnName("PODate");

                entity.Property(e => e.PodlastPurchasePrice)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PODLastPurchasePrice");

                entity.Property(e => e.PodlineSerial).HasColumnName("PODLineSerial");

                entity.Property(e => e.PodpurchaseBasePrice)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PODPurchaseBasePrice");

                entity.Property(e => e.PodpurchasePrice)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PODPurchasePrice");

                entity.Property(e => e.PodpurchaseUnit)
                    .HasMaxLength(10)
                    .HasColumnName("PODPurchaseUnit")
                    .IsFixedLength(true);

                entity.Property(e => e.Podqty)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PODQty");

                entity.Property(e => e.Podreceived).HasColumnName("PODReceived");

                entity.Property(e => e.PodtotalBaseLine)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PODTotalBaseLine");

                entity.Property(e => e.PodtotalLine)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PODTotalLine");

                entity.Property(e => e.PoendDate)
                    .HasColumnType("datetime")
                    .HasColumnName("POEndDate");

                entity.Property(e => e.PoinsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("POInsertDate");

                entity.Property(e => e.PoinsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("POInsertUID");

                entity.Property(e => e.PootherExpenses)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("POOtherExpenses");

                entity.Property(e => e.PopaymentType)
                    .HasMaxLength(2)
                    .HasColumnName("POPaymentType");

                entity.Property(e => e.PopostingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("POPostingDate");

                entity.Property(e => e.Poremarks).HasColumnName("PORemarks");

                entity.Property(e => e.Poserial)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("POSerial");

                entity.Property(e => e.PostartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("POStartDate");

                entity.Property(e => e.Postatus).HasColumnName("POStatus");

                entity.Property(e => e.PototalItems).HasColumnName("POTotalItems");

                entity.Property(e => e.PototalShippingExpenses)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("POTotalShippingExpenses");

                entity.Property(e => e.PototalTax)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("POTotal_Tax");

                entity.Property(e => e.PototalValue)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("POTotalValue");

                entity.Property(e => e.PoupdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("POUpdateDate");

                entity.Property(e => e.PoupdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("POUpdateUID");

                entity.Property(e => e.PovenSerial).HasColumnName("POVenSerial");

                entity.Property(e => e.Poyear).HasColumnName("POYear");

                entity.Property(e => e.ReceivedQty).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.StoName).IsRequired();

                entity.Property(e => e.UnitName).HasMaxLength(50);

                entity.Property(e => e.VendorName).IsRequired();

                entity.Property(e => e.XAttributeValue)
                    .IsRequired()
                    .HasColumnName("X_AttributeValue");

                entity.Property(e => e.YAttributeValue)
                    .IsRequired()
                    .HasColumnName("Y_AttributeValue");
            });

            modelBuilder.Entity<PurchaseRequestDetail>(entity =>
            {
                entity.HasKey(e => new { e.ComCode, e.StoCode, e.Prserial, e.PrdlineSerial, e.Prdyear });

                entity.Property(e => e.ComCode).HasMaxLength(3);

                entity.Property(e => e.StoCode).HasMaxLength(3);

                entity.Property(e => e.Prserial)
                    .HasMaxLength(50)
                    .HasColumnName("PRSerial");

                entity.Property(e => e.PrdlineSerial).HasColumnName("PRDLineSerial");

                entity.Property(e => e.Prdyear).HasColumnName("PRDYear");

                entity.Property(e => e.LastPurchasePrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PrCurrentBalance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PrdinsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PRDInsertDate");

                entity.Property(e => e.PrdinsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("PRDInsertUID");

                entity.Property(e => e.PrditmUnitCode)
                    .HasMaxLength(10)
                    .HasColumnName("PRDItmUnitCode");

                entity.Property(e => e.Prdqty)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PRDQty");

                entity.Property(e => e.Prdremarks)
                    .HasMaxLength(500)
                    .HasColumnName("PRDRemarks");

                entity.Property(e => e.PrdretunrQty)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PRDRetunrQty");

                entity.Property(e => e.Prdstatus).HasColumnName("PRDStatus");

                entity.Property(e => e.PrdunitFactor)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PRDUnitFactor");

                entity.Property(e => e.PrdupdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PRDUpdateDate");

                entity.Property(e => e.PrdupdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("PRDUpdateUID");

                entity.Property(e => e.PrtotalQtyInSmallUnit)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PRTotalQtyInSmallUnit");

                entity.Property(e => e.PrunitPrice)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PRUnitPrice");
            });

            modelBuilder.Entity<PurchaseRequestDetailsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PurchaseRequestDetails_View");

                entity.Property(e => e.ComCode)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.ComName1).IsRequired();

                entity.Property(e => e.ComName2).IsRequired();

                entity.Property(e => e.ItemNameL1).IsRequired();

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.LastPurchasePrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PrCurrentBalance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PrdinsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PRDInsertDate");

                entity.Property(e => e.PrdinsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("PRDInsertUID");

                entity.Property(e => e.PrditmUnitCode)
                    .HasMaxLength(10)
                    .HasColumnName("PRDItmUnitCode");

                entity.Property(e => e.PrdlineSerial).HasColumnName("PRDLineSerial");

                entity.Property(e => e.Prdqty)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PRDQty");

                entity.Property(e => e.Prdremarks)
                    .HasMaxLength(500)
                    .HasColumnName("PRDRemarks");

                entity.Property(e => e.PrdretunrQty)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PRDRetunrQty");

                entity.Property(e => e.Prdstatus).HasColumnName("PRDStatus");

                entity.Property(e => e.PrdstatusDesc)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRDStatusDesc");

                entity.Property(e => e.PrdunitFactor)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PRDUnitFactor");

                entity.Property(e => e.PrdunitName1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PRDUnitName1");

                entity.Property(e => e.PrdunitName2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PRDUnitName2");

                entity.Property(e => e.PrdupdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PRDUpdateDate");

                entity.Property(e => e.PrdupdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("PRDUpdateUID");

                entity.Property(e => e.Prdyear).HasColumnName("PRDYear");

                entity.Property(e => e.Prserial)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PRSerial");

                entity.Property(e => e.PrtotalQtyInSmallUnit)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PRTotalQtyInSmallUnit");

                entity.Property(e => e.PrunitPrice)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PRUnitPrice");

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.StoName1).IsRequired();

                entity.Property(e => e.StoName2).IsRequired();
            });

            modelBuilder.Entity<PurchaseRequestHeader>(entity =>
            {
                entity.HasKey(e => new { e.Prserial, e.Pryear });

                entity.ToTable("PurchaseRequestHeader");

                entity.Property(e => e.Prserial)
                    .HasMaxLength(50)
                    .HasColumnName("PRSerial");

                entity.Property(e => e.Pryear).HasColumnName("PRYear");

                entity.Property(e => e.BaseCurrencyCode).HasMaxLength(10);

                entity.Property(e => e.BaseTotalValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ComCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CurrencyXrate)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("CurrencyXRate");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Poserial)
                    .HasMaxLength(50)
                    .HasColumnName("POSerial");

                entity.Property(e => e.PrcurrencyCode)
                    .HasMaxLength(10)
                    .HasColumnName("PRCurrencyCode");

                entity.Property(e => e.PrdocNo)
                    .HasMaxLength(50)
                    .HasColumnName("PRDocNo");

                entity.Property(e => e.PrinsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PRInsertDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PrinsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("PRInsertUID");

                entity.Property(e => e.PrpostFlag).HasColumnName("PRPostFlag");

                entity.Property(e => e.PrpostUserCode)
                    .HasMaxLength(50)
                    .HasColumnName("PRPostUserCode");

                entity.Property(e => e.PrpostingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PRPostingDate");

                entity.Property(e => e.Prremarks)
                    .HasMaxLength(500)
                    .HasColumnName("PRRemarks");

                entity.Property(e => e.PrtotalItems).HasColumnName("PRTotalItems");

                entity.Property(e => e.PrtotalValue)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PRTotalValue");

                entity.Property(e => e.PrupdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PRUpdateDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PrupdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("PRUpdateUID");

                entity.Property(e => e.PrvenSerial).HasColumnName("PRVenSerial");

                entity.Property(e => e.StoCode).HasMaxLength(10);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.PurchaseRequestHeaders)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_PurchaseRequestHeader_Departments");
            });

            modelBuilder.Entity<PurchaseRequestHeaderView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PurchaseRequestHeader_View");

                entity.Property(e => e.BaseCurrencyCode).HasMaxLength(10);

                entity.Property(e => e.BaseCurrencyName1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BaseCurrencyName2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BaseTotalValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ComCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ComName1).IsRequired();

                entity.Property(e => e.ComName2).IsRequired();

                entity.Property(e => e.CurrencyName1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CurrencyName2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CurrencyXrate)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("CurrencyXRate");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentName1).IsRequired();

                entity.Property(e => e.DepartmentName2).IsRequired();

                entity.Property(e => e.Poserial)
                    .HasMaxLength(50)
                    .HasColumnName("POSerial");

                entity.Property(e => e.PostFlagDesc)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PrcurrencyCode)
                    .HasMaxLength(10)
                    .HasColumnName("PRCurrencyCode");

                entity.Property(e => e.PrdocNo)
                    .HasMaxLength(50)
                    .HasColumnName("PRDocNo");

                entity.Property(e => e.PrinsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PRInsertDate");

                entity.Property(e => e.PrinsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("PRInsertUID");

                entity.Property(e => e.PrpostFlag).HasColumnName("PRPostFlag");

                entity.Property(e => e.PrpostUserCode)
                    .HasMaxLength(50)
                    .HasColumnName("PRPostUserCode");

                entity.Property(e => e.PrpostingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PRPostingDate");

                entity.Property(e => e.Prremarks)
                    .HasMaxLength(500)
                    .HasColumnName("PRRemarks");

                entity.Property(e => e.Prserial)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PRSerial");

                entity.Property(e => e.PrtotalItems).HasColumnName("PRTotalItems");

                entity.Property(e => e.PrtotalValue)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PRTotalValue");

                entity.Property(e => e.PrupdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PRUpdateDate");

                entity.Property(e => e.PrupdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("PRUpdateUID");

                entity.Property(e => e.PrvenSerial).HasColumnName("PRVenSerial");

                entity.Property(e => e.Pryear).HasColumnName("PRYear");

                entity.Property(e => e.StoCode).HasMaxLength(10);

                entity.Property(e => e.StoName1).IsRequired();

                entity.Property(e => e.StoName2).IsRequired();

                entity.Property(e => e.VendorName1).IsRequired();

                entity.Property(e => e.VendorName2).IsRequired();
            });

            modelBuilder.Entity<PurchaseReturnDetailsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PurchaseReturnDetails_View");

                entity.Property(e => e.DescriptionInSales).IsRequired();

                entity.Property(e => e.DocumentDiscountValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ExpensesDistributed).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ItemDiscountValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ItmCode)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ItmCode1).IsRequired();

                entity.Property(e => e.ItmSalesPrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.NextBalance).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.OtherCostValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Pirserial)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PIRSerial");

                entity.Property(e => e.PreviouseBalance).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.PurchaseUnitCode)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.PurchaseUnitName1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PurchaseUnitName2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RecTransSerial).ValueGeneratedOnAdd();

                entity.Property(e => e.TotalCustomValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalQtyPrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransItmTaxValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransLastPurchasePrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransQty).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransSalesTaxValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransUnitPrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Year)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<PurchaseReturnHeaderView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PurchaseReturnHeader_View");

                entity.Property(e => e.BaseNetAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BaseTotalDiscountValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BaseTotalItemsValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BaseTotalTaxValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ComCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CompanyName1).IsRequired();

                entity.Property(e => e.CompanyName2).IsRequired();

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CurrencyNameL1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CurrencyNameL2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InvoiceDate).HasColumnType("date");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Pirserial)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PIRSerial");

                entity.Property(e => e.PostFlag)
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.Property(e => e.PostedBy).HasMaxLength(50);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.StoName1).IsRequired();

                entity.Property(e => e.StoName2).IsRequired();

                entity.Property(e => e.TotalDiscountValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalItemsValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalNoOfItems).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.TotalQty).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.TotalSalesTaxValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalTaxValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");

                entity.Property(e => e.VendorNameL1).IsRequired();

                entity.Property(e => e.VendorNameL2).IsRequired();
            });

            modelBuilder.Entity<PurchaseReturnView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PurchaseReturn_View");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CurrencyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DocumentDiscountValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.InvoiceDate).HasColumnType("date");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.ItemDiscountValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ItmInputCode).HasMaxLength(50);

                entity.Property(e => e.ModelCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NameL1).IsRequired();

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.PostFlag)
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.Property(e => e.PostedBy).HasMaxLength(50);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.StoreName).IsRequired();

                entity.Property(e => e.TotalDiscountValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalItemsValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalQtyPrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalSalesTaxValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalTaxValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.TransItmTaxValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TransQty).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransSalesTaxValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransTypeCodeLevel1)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TransUnitPrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.UnitName).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");

                entity.Property(e => e.XAttributeValue)
                    .IsRequired()
                    .HasColumnName("X_AttributeValue");

                entity.Property(e => e.YAttributeValue)
                    .IsRequired()
                    .HasColumnName("Y_AttributeValue");
            });

            modelBuilder.Entity<PurchasingItemByVendorView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PurchasingItemByVendor_view");

                entity.Property(e => e.CurrentBalance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Expr1).HasMaxLength(50);

                entity.Property(e => e.Expr2).IsRequired();

                entity.Property(e => e.ItemDiscountValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ItmInputCode).HasMaxLength(50);

                entity.Property(e => e.ModelCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NameL1).IsRequired();

                entity.Property(e => e.NextBalance).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.PreviouseBalance).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TotalQtyPrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.TransQty).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransSalesTaxValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransUnitPrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");

                entity.Property(e => e.XAttributeValue)
                    .IsRequired()
                    .HasColumnName("X_AttributeValue");

                entity.Property(e => e.YAttributeValue)
                    .IsRequired()
                    .HasColumnName("Y_AttributeValue");
            });

            modelBuilder.Entity<QuotationDetailsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QuotationDetails_View");

                entity.Property(e => e.AverageCost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.AverageLandedCost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BaseDiscountForItem).HasColumnType("decimal(37, 8)");

                entity.Property(e => e.BaseDiscountForItemValue).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.BaseNetPrice).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.BaseTaxesForItem).HasColumnType("decimal(37, 8)");

                entity.Property(e => e.BaseTaxesForItemValue).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.BaseTotalLine).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.BaseUnitPrice).HasColumnType("decimal(37, 8)");

                entity.Property(e => e.BonusQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DiscountForItem).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DiscountForItemValue).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.DiscountTypeDesc)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountValueFromHeader).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ExpensesForItem).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ExpensesValueFromHeader).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ItemNameL1).IsRequired();

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.NetPrice).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TaxesForItem).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TaxesForItemValue).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.TaxesTypeDesc)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TaxesValueFromHeader).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TotalLine).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.TransNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UnitCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UnitNameL1).HasMaxLength(50);

                entity.Property(e => e.UnitNameL2).HasMaxLength(50);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid).HasMaxLength(50);
            });

            modelBuilder.Entity<QuotationHeaderView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QuotationHeader_View");

                entity.Property(e => e.BaseCurrencyCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BaseCurrencyNameL1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BaseCurrencyNameL2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BaseCurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.BaseDiscount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.BaseDiscountValue).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.BaseGrossAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.BaseNetAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.BaseTaxes).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.BaseTaxesValue).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.BaseTotalExpenses).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ComCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CommercialRegistrationExpireDate).HasColumnType("date");

                entity.Property(e => e.CommercialRegistrationNo).HasMaxLength(50);

                entity.Property(e => e.CompanyName1).IsRequired();

                entity.Property(e => e.ContactPerson).HasMaxLength(50);

                entity.Property(e => e.CreditLimit).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.CreditPeriod)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CurrencyNameL1).HasMaxLength(50);

                entity.Property(e => e.CurrencyNameL2).HasMaxLength(50);

                entity.Property(e => e.CurrencySymbol)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerNameL1).HasMaxLength(200);

                entity.Property(e => e.CustomerNameL2).HasMaxLength(200);

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.DiscountTypeDesc)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountValue).HasColumnType("decimal(38, 9)");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.GrossAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.InvoiceDate).HasColumnType("date");

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.MailAddress).HasMaxLength(50);

                entity.Property(e => e.MunicipalityApprovalExpireDate).HasColumnType("date");

                entity.Property(e => e.MunicipalityApprovalNo).HasMaxLength(50);

                entity.Property(e => e.Nationality).HasMaxLength(50);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.OrigTransNo).HasMaxLength(50);

                entity.Property(e => e.OrigTransTypeCodeLevel1).HasMaxLength(50);

                entity.Property(e => e.OrigTransTypeCodeLevel1Desc)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.OrigTransTypeCodeLevel2).HasMaxLength(50);

                entity.Property(e => e.OrigTransTypeCodeLevel2Desc)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Pobox)
                    .HasMaxLength(50)
                    .HasColumnName("POBOX");

                entity.Property(e => e.QuotationNo).HasMaxLength(50);

                entity.Property(e => e.Rfqdate)
                    .HasColumnType("date")
                    .HasColumnName("RFQDate");

                entity.Property(e => e.Rfqno)
                    .HasMaxLength(50)
                    .HasColumnName("RFQNo");

                entity.Property(e => e.SaleManNameL1).IsRequired();

                entity.Property(e => e.SaleManNameL2).IsRequired();

                entity.Property(e => e.SalesManId).HasColumnName("SalesManID");

                entity.Property(e => e.SponserId)
                    .HasMaxLength(50)
                    .HasColumnName("SponserID");

                entity.Property(e => e.SponsorIdexpireDate)
                    .HasColumnType("date")
                    .HasColumnName("SponsorIDExpireDate");

                entity.Property(e => e.StatusDesc)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StoName1).IsRequired();

                entity.Property(e => e.StoName2).IsRequired();

                entity.Property(e => e.Taxes).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TaxesTypeDesc)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TaxesValue).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalExpenses).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalLandedCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.TransNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TransTypeCodeLevel1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TransTypeCodeLevel2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<Reason>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(getdate())", false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<ReceivingItemsTempCollector>(entity =>
            {
                entity.ToTable("ReceivingItemsTempCollector");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BarCode).HasMaxLength(50);

                entity.Property(e => e.BatchNo).HasMaxLength(50);

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.OriginalTransNo).HasMaxLength(50);

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.StoCode).HasMaxLength(50);

                entity.Property(e => e.TransNo).HasMaxLength(50);

                entity.Property(e => e.TransTypeCodeLevel1).HasMaxLength(10);

                entity.Property(e => e.TransTypeCodeLevel2).HasMaxLength(10);

                entity.Property(e => e.UserCode).HasMaxLength(50);
            });

            modelBuilder.Entity<RecieveTransHeader>(entity =>
            {
                entity.HasKey(e => new { e.ComCode, e.StoCode, e.TransTypeCodeLevel1, e.TransTypeCodeLevel2, e.TransNo });

                entity.ToTable("RecieveTransHeader");

                entity.HasIndex(e => e.TransNo, "IX_RecieveTransHeader_1");

                entity.HasIndex(e => e.TransTypeCodeLevel1, "IX_RecieveTransHeader_2");

                entity.Property(e => e.ComCode)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.StoCode)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TransTypeCodeLevel1)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TransTypeCodeLevel2)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TransNo).HasMaxLength(50);

                entity.Property(e => e.BaseCurrencyCode).HasMaxLength(10);

                entity.Property(e => e.BaseNetAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BasePaidAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BaseTotalDiscountValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BaseTotalItemsValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BaseTotalOthersValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BaseTotalTaxValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(getdate())", false);

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.InvoiceDate).HasColumnType("date");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.OrigTransNo).HasMaxLength(50);

                entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.PostFlag)
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.ReTransTypeCodeLevel1)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ReTransTypeCodeLevel2)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ReferenceTotal).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ReturnStoreCode)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TotalCustomsValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalDiscountValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalItemsValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalNoOfItems).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.TotalOthersValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalSalesTaxValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalTaxValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<RecieveTransItem>(entity =>
            {
                entity.HasKey(e => e.RecTransSerial)
                    .HasName("PK_RecieveTransItems_1");

                entity.HasIndex(e => new { e.TransNo, e.ItmSerial }, "IX_RecieveTransItems_1");

                entity.HasIndex(e => e.TransNo, "IX_RecieveTransItems_4");

                entity.HasIndex(e => e.TransNo, "IX_RecieveTransItems_5");

                entity.HasIndex(e => new { e.TransTypeCodeLevel1, e.TransTypeCodeLevel2 }, "IX_RecieveTransItems_6");

                entity.HasIndex(e => new { e.TransTypeCodeLevel1, e.TransTypeCodeLevel2 }, "IX_RecieveTransItems_7");

                entity.HasIndex(e => new { e.TransTypeCodeLevel1, e.TransTypeCodeLevel2 }, "IX_RecieveTransItems_8");

                entity.Property(e => e.BonusQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ComCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.DocumentDiscountValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ExpensesDistributed).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ExpirationDate).HasColumnType("date");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.ItemDiscountValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ItmInputCode).HasMaxLength(50);

                entity.Property(e => e.ItmSalesPrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.NextBalance).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.OtherCostValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.OtherStore)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.PreviouseBalance).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ReturnQty).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TotalCustomValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalQtyCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalQtyPrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalSalesPrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransItmTaxValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransLastPurchasePrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransMeasureUnit)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TransNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TransQty).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransSalesTaxValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransTypeCodeLevel1)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TransTypeCodeLevel2)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TransUnitPrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");

                entity.Property(e => e.Year)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<RecipeItemsDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RecipeItemsDetails");

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.ItmQty).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MainItemName).IsRequired();

                entity.Property(e => e.MainItemUnitCode).HasMaxLength(10);

                entity.Property(e => e.MainItemUnitName).HasMaxLength(50);

                entity.Property(e => e.MainItemUnitType)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.MainItemUnitTypeDesc)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.MaterialItemCode).HasMaxLength(250);

                entity.Property(e => e.MaterialItemname).IsRequired();

                entity.Property(e => e.MaterialSalesPrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.MaterialTotalPrice).HasColumnType("decimal(37, 10)");

                entity.Property(e => e.SalesPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SalesUnitCode).HasMaxLength(10);

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.StoreName).IsRequired();

                entity.Property(e => e.TotalMaterialCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.UnitName).HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<RegLogUser>(entity =>
            {
                entity.HasKey(e => e.LoginId);

                entity.ToTable("RegLogUser");

                entity.Property(e => e.LoginId).HasColumnName("LoginID");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Remark>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.RemarkType });

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RemarkType).HasComment("0 ==> Invoice Remark, 1 ==> Kitchen Note, 2 ==> Void Reason, 3 ==> Return Reason");

                entity.Property(e => e.Remark1).HasColumnName("Remark");
            });

            modelBuilder.Entity<RequisitionDetailsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RequisitionDetails_View");

                entity.Property(e => e.ApprovedQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DelivQty).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ItemStatus).HasMaxLength(10);

                entity.Property(e => e.ItemStatusDescr)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ItemTransferStatus)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.ItmUnitCode).HasMaxLength(10);

                entity.Property(e => e.NotApprovedQty).HasColumnType("decimal(19, 3)");

                entity.Property(e => e.NotDelivQty).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReqQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Reqserial)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("REQSerial");

                entity.Property(e => e.TotalItemCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransQty).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.UnitNameL1).HasMaxLength(50);

                entity.Property(e => e.UnitNameL2).HasMaxLength(50);
            });

            modelBuilder.Entity<RequisitionHeader>(entity =>
            {
                entity.HasKey(e => new { e.TransNo, e.ComCode, e.FromStoCode, e.ToStoCode });

                entity.ToTable("RequisitionHeader");

                entity.Property(e => e.TransNo).HasMaxLength(50);

                entity.Property(e => e.ComCode).HasMaxLength(10);

                entity.Property(e => e.FromStoCode).HasMaxLength(10);

                entity.Property(e => e.ToStoCode).HasMaxLength(10);

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(getdate())", false);

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.PostFlag)
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.ReqDocumentDate).HasColumnType("date");

                entity.Property(e => e.ReqDocumentNo).HasMaxLength(50);

                entity.Property(e => e.RequestStatus)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalNoOfItems).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<RequisitionHeaderView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RequisitionHeader_View");

                entity.Property(e => e.ComCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CompanyNameL1).IsRequired();

                entity.Property(e => e.CompanyNameL2).IsRequired();

                entity.Property(e => e.FromStoCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.FromStoreNameL1).IsRequired();

                entity.Property(e => e.FromStoreNameL2).IsRequired();

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.ReqDocumentDate).HasColumnType("date");

                entity.Property(e => e.ReqDocumentNo).HasMaxLength(50);

                entity.Property(e => e.Reqserial)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("REQSerial");

                entity.Property(e => e.RequisitionStatus).HasMaxLength(10);

                entity.Property(e => e.RequisitionStatusDescr)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ToStoCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ToStoreNameL1).IsRequired();

                entity.Property(e => e.ToStoreNameL2).IsRequired();

                entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalNoOfItems).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalQty).HasColumnType("decimal(38, 3)");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<RequisitionItem>(entity =>
            {
                entity.HasKey(e => new { e.TransNo, e.LineSerial });

                entity.Property(e => e.TransNo).HasMaxLength(50);

                entity.Property(e => e.ApprovedQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(getdate())", false);

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.ItmUnitCode).HasMaxLength(10);

                entity.Property(e => e.ReqQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.RequestStatus)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReturnQty)
                    .HasColumnType("decimal(19, 3)")
                    .HasComputedColumnSql("([ReqQty]-[ApprovedQty])", false);

                entity.Property(e => e.TotalItemCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<RequisitionView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Requisition_View");

                entity.Property(e => e.ApprovedQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ComCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CompanyNameL1).IsRequired();

                entity.Property(e => e.DelivQty).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.FromStoCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.FromStoreNameL1).IsRequired();

                entity.Property(e => e.FromStoreNameL2).IsRequired();

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.ItemNameL1).IsRequired();

                entity.Property(e => e.ItemStatus).HasMaxLength(10);

                entity.Property(e => e.ItemStatusDescr)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ItemTransferStatus)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.ItmUnitCode).HasMaxLength(10);

                entity.Property(e => e.NotApprovedQty).HasColumnType("decimal(19, 3)");

                entity.Property(e => e.NotDelivQty).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReqDocumentDate).HasColumnType("date");

                entity.Property(e => e.ReqDocumentNo).HasMaxLength(50);

                entity.Property(e => e.ReqQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.RequisitionStatus).HasMaxLength(10);

                entity.Property(e => e.RequisitionStatusDescr)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ToStoCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ToStoreNameL1).IsRequired();

                entity.Property(e => e.ToStoreNameL2).IsRequired();

                entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalItemCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalNoOfItems).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.TransNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TransQty).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.UnitNameL1).HasMaxLength(50);

                entity.Property(e => e.UnitNameL2).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ReservationCompanion>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.PersonalId)
                    .HasMaxLength(50)
                    .HasColumnName("PersonalID");

                entity.Property(e => e.ResTransNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SpouseDate).HasColumnType("date");
            });

            modelBuilder.Entity<ReservationHeader>(entity =>
            {
                entity.HasKey(e => e.ResTransNo);

                entity.ToTable("ReservationHeader");

                entity.Property(e => e.ResTransNo).HasMaxLength(50);

                entity.Property(e => e.ArrivalDateTime).HasColumnType("datetime");

                entity.Property(e => e.DepatureDateTime).HasColumnType("datetime");

                entity.Property(e => e.GuestFirstName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.GuestLastName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.RoomNo).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(1);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<RetailCustomer>(entity =>
            {
                entity.Property(e => e.ApplyDiscount).HasDefaultValueSql("((1))");

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.CardCode).HasMaxLength(50);

                entity.Property(e => e.CreditPoints).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CurrentPointsBalance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DebitPoints).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GENDER")
                    .IsFixedLength(true);

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(10)
                    .HasColumnName("InsertUID")
                    .IsFixedLength(true);

                entity.Property(e => e.LastSalesAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LastSalesDate).HasColumnType("datetime");

                entity.Property(e => e.NationalityId).HasColumnName("NationalityID");

                entity.Property(e => e.OpeningBalancePoints).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Phone2).HasMaxLength(20);

                entity.Property(e => e.Phone3).HasMaxLength(20);

                entity.Property(e => e.Phone4).HasMaxLength(20);

                entity.Property(e => e.Phone5).HasMaxLength(20);

                entity.Property(e => e.SalesVolume).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<RetailCustomerPointsStatement>(entity =>
            {
                entity.ToTable("RetailCustomerPointsStatement");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Credit).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CusId).HasColumnName("CusID");

                entity.Property(e => e.Debit).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DocumentNo).HasMaxLength(50);

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<ReturnedSalesView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ReturnedSales_view");

                entity.Property(e => e.BeforeDiscountPrice).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.InsertUid).HasMaxLength(50);

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasColumnName("Item_Name");

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.ModelCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OrigSalesTrnsId)
                    .HasMaxLength(50)
                    .HasColumnName("OrigSalesTrnsID");

                entity.Property(e => e.OriginalNetAmount).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.OriginalTrnsDate).HasColumnType("date");

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StoreName)
                    .IsRequired()
                    .HasColumnName("Store_Name");

                entity.Property(e => e.TerminalName).HasColumnName("Terminal_Name");

                entity.Property(e => e.TransSerial)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TransType1).HasMaxLength(50);

                entity.Property(e => e.TrnsDate).HasColumnType("date");

                entity.Property(e => e.TrnsQty).HasColumnType("decimal(22, 5)");

                entity.Property(e => e.UnitSalesPrice).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.UserId).HasMaxLength(50);

                entity.Property(e => e.XAttributeValue)
                    .IsRequired()
                    .HasColumnName("X_AttributeValue");

                entity.Property(e => e.YAttributeValue)
                    .IsRequired()
                    .HasColumnName("Y_AttributeValue");
            });

            modelBuilder.Entity<SalesDetailsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SalesDetails_View");

                entity.Property(e => e.AddOnsUnitPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.AverageCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.BeforeDiscountPrice).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.CashAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.ComCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CompanyNameL1).IsRequired();

                entity.Property(e => e.CompanyNameL2).IsRequired();

                entity.Property(e => e.CouponAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CouponNo).HasMaxLength(50);

                entity.Property(e => e.CreditCardExpiry).HasColumnType("date");

                entity.Property(e => e.CreditCardNo).HasMaxLength(50);

                entity.Property(e => e.CreditCustomerAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DayCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DiscountPercent).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DiscountValueForHeader).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.DiscountValueForItem).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.EndUserCode).HasMaxLength(50);

                entity.Property(e => e.GrossAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.GroupCode).HasMaxLength(3);

                entity.Property(e => e.GroupName).HasMaxLength(200);

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid).HasMaxLength(50);

                entity.Property(e => e.ItemInsertDate).HasColumnType("datetime");

                entity.Property(e => e.ItemInsertUid).HasMaxLength(50);

                entity.Property(e => e.ItemSalesManId).HasColumnName("ItemSalesManID");

                entity.Property(e => e.ItemTableId).HasColumnName("ItemTableID");

                entity.Property(e => e.ItemTotalValue).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.ItemUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.ItemUpdateUid).HasMaxLength(50);

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.KitchenId).HasColumnName("KitchenID");

                entity.Property(e => e.MarkComId).HasColumnName("MarkComID");

                entity.Property(e => e.MarketingCompanyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MinimumChargeAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ModelCode).HasMaxLength(50);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.OrderDesc)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.OrigSalesTrnsId)
                    .HasMaxLength(50)
                    .HasColumnName("OrigSalesTrnsID");

                entity.Property(e => e.OtherCost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PhoneNo).HasMaxLength(50);

                entity.Property(e => e.PointsAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.PostFlag)
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.Property(e => e.ReceiptStatusDesc)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SaleMid).HasColumnName("SaleMID");

                entity.Property(e => e.SalesTrnsId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SalesType)
                    .HasMaxLength(2)
                    .IsFixedLength(true);

                entity.Property(e => e.SalesTypeDesc)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalestaxValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ServiceChargeAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.StartUserCode).HasMaxLength(50);

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StoreNameL1).IsRequired();

                entity.Property(e => e.StoreNameL2).IsRequired();

                entity.Property(e => e.TerminalId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TerminalNameL1).IsRequired();

                entity.Property(e => e.TerminalNameL2).IsRequired();

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TotalDiscount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TotalTaxs).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TransType1).HasMaxLength(50);

                entity.Property(e => e.TransType1Desc)
                    .HasMaxLength(22)
                    .IsUnicode(false);

                entity.Property(e => e.TransType2).HasMaxLength(2);

                entity.Property(e => e.TransType2Desc)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TransUserNo).HasMaxLength(50);

                entity.Property(e => e.TrnsDate).HasColumnType("date");

                entity.Property(e => e.TrnsQty).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.UnitId)
                    .HasMaxLength(10)
                    .HasColumnName("UnitID")
                    .IsFixedLength(true);

                entity.Property(e => e.UnitNameL1).HasMaxLength(50);

                entity.Property(e => e.UnitNameL2).HasMaxLength(50);

                entity.Property(e => e.UnitSalesPrice).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid).HasMaxLength(50);

                entity.Property(e => e.UserCode).HasMaxLength(50);

                entity.Property(e => e.VisaAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.XAttributeValue).HasColumnName("X_AttributeValue");

                entity.Property(e => e.YAttributeValue).HasColumnName("Y_AttributeValue");

                entity.Property(e => e.Year)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<SalesHeaderView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SalesHeader_view");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CashAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CouponAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CourierId).HasColumnName("CourierID");

                entity.Property(e => e.CreditCustomerAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DeliveryCharge).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.GrossAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.IssueType)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PhoneNo).HasMaxLength(50);

                entity.Property(e => e.PointsAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.PostFlag)
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.Property(e => e.Rebate).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.RebateTypeDesc).HasMaxLength(50);

                entity.Property(e => e.RebateValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ReceiptStatus)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SaleMid).HasColumnName("SaleMID");

                entity.Property(e => e.SalesMan).IsRequired();

                entity.Property(e => e.SalesTrnsId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SalesType)
                    .HasMaxLength(2)
                    .IsFixedLength(true);

                entity.Property(e => e.SalesTypeDesc)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceChargeAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ShiftEndDate).HasColumnType("datetime");

                entity.Property(e => e.ShiftStartDate).HasColumnType("datetime");

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StoreName).IsRequired();

                entity.Property(e => e.TerminalId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TerminalName).IsRequired();

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TotalAmountAfterRebate).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TotalDiscount).HasColumnType("decimal(20, 3)");

                entity.Property(e => e.TotalPaidAmount).HasColumnType("decimal(38, 3)");

                entity.Property(e => e.TotalRemainningAmount).HasColumnType("decimal(38, 3)");

                entity.Property(e => e.TotalTaxs).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TransType1).HasMaxLength(2);

                entity.Property(e => e.TransType2).HasMaxLength(2);

                entity.Property(e => e.TrnsDate).HasColumnType("date");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid).HasMaxLength(50);

                entity.Property(e => e.VisaAmount).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<SalesItemDetailsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SalesItemDetails_View");

                entity.Property(e => e.AverageCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.BeforeDiscountPrice).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.DiscountValueForHeader).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.DiscountValueForItem).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.GroupCode).HasMaxLength(3);

                entity.Property(e => e.GroupName).HasMaxLength(200);

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.ItemCode).HasMaxLength(250);

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ModelCode).HasMaxLength(50);

                entity.Property(e => e.PostFlag)
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.Property(e => e.Profit).HasColumnType("decimal(38, 7)");

                entity.Property(e => e.SalesType)
                    .HasMaxLength(2)
                    .IsFixedLength(true);

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StoreName).IsRequired();

                entity.Property(e => e.TotalAfterDiscount).HasColumnType("decimal(38, 7)");

                entity.Property(e => e.TotalBeforDiscount).HasColumnType("decimal(38, 9)");

                entity.Property(e => e.TotalCost).HasColumnType("decimal(37, 10)");

                entity.Property(e => e.TransSerial)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TransType1).HasMaxLength(50);

                entity.Property(e => e.TransType2).HasMaxLength(2);

                entity.Property(e => e.TrnsQty).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.UnitId)
                    .HasMaxLength(10)
                    .HasColumnName("UnitID")
                    .IsFixedLength(true);

                entity.Property(e => e.UnitName).HasMaxLength(50);

                entity.Property(e => e.UnitSalesPrice).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.XAttributeValue).HasColumnName("X_AttributeValue");

                entity.Property(e => e.YAttributeValue).HasColumnName("Y_AttributeValue");

                entity.Property(e => e.Year)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<SalesMan>(entity =>
            {
                entity.HasKey(e => e.SalesSerial);

                entity.ToTable("SalesMan");

                entity.Property(e => e.ComCode)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CommPercentage).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(getdate())", false);

                entity.Property(e => e.Smcode)
                    .HasMaxLength(10)
                    .HasColumnName("SMCode")
                    .IsFixedLength(true);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.SalesMen)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SalesMan_Employees");
            });

            modelBuilder.Entity<SalesManItem>(entity =>
            {
                entity.HasIndex(e => new { e.ItmSerial, e.SalesManId }, "IX_SalesManItems")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.SalesManId).HasColumnName("SalesManID");
            });

            modelBuilder.Entity<SalesOrderDeliverySchedule>(entity =>
            {
                entity.HasKey(e => new { e.Soserial, e.DeliveryLineSerial });

                entity.ToTable("SalesOrderDeliverySchedule");

                entity.Property(e => e.Soserial)
                    .HasMaxLength(50)
                    .HasColumnName("SOSerial");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DeliveryAddress).IsRequired();

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UpdateDate).HasColumnType("date");

                entity.Property(e => e.UpdateUid).HasMaxLength(50);
            });

            modelBuilder.Entity<SalesOrderDetail>(entity =>
            {
                entity.HasKey(e => new { e.TransNo, e.LineSerial });

                entity.Property(e => e.TransNo).HasMaxLength(50);

                entity.Property(e => e.AddOnsUnitPrice)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AverageCost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.AverageLandedCost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BonusQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BonusQtyReadyForDelivery)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ComCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeliveredBonusQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DeliveredQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DiscountForItem).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DiscountValueFromHeader).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ExpensesForItem).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ExpensesValueFromHeader).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.QtyReadyForDelivery)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TaxesForItem).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TaxesValueFromHeader).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TransTypeCodeLevel1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TransTypeCodeLevel2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UnitCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid).HasMaxLength(50);

                entity.Property(e => e.VoidedBonusQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.VoidedQty).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<SalesOrderDetailsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SalesOrderDetails_View");

                entity.Property(e => e.AddOnsUnitPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.AverageCost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.AverageLandedCost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BaseDiscountForItem).HasColumnType("decimal(37, 8)");

                entity.Property(e => e.BaseDiscountForItemValue).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.BaseNetPrice).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.BaseTaxesForItem).HasColumnType("decimal(37, 8)");

                entity.Property(e => e.BaseTaxesForItemValue).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.BaseTotalLine).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.BaseUnitAndAddOnsPrice).HasColumnType("decimal(37, 8)");

                entity.Property(e => e.BaseUnitPrice).HasColumnType("decimal(37, 8)");

                entity.Property(e => e.BonusQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BonusQtyReadyForDelivery).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BonusQtyToBeReadyForDelivery).HasColumnType("decimal(20, 3)");

                entity.Property(e => e.DeliveredBonusQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DeliveredQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DiscountForItem).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DiscountForItemValue).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.DiscountTypeDesc)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountValueFromHeader).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ExpensesForItem).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ExpensesValueFromHeader).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ItemNameL1).IsRequired();

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.LastSalesPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.NetPrice).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.OfferDefaultPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PriceListDefaultPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.QtyReadyForDelivery).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.QtyToBeReadyForDelivery).HasColumnType("decimal(20, 3)");

                entity.Property(e => e.TaxesForItem).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TaxesForItemValue).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.TaxesTypeDesc)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TaxesValueFromHeader).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TotalLine).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.TransNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UnitAndAddOnsPrice).HasColumnType("decimal(19, 3)");

                entity.Property(e => e.UnitCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UnitNameL1).HasMaxLength(50);

                entity.Property(e => e.UnitNameL2).HasMaxLength(50);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid).HasMaxLength(50);

                entity.Property(e => e.VoidedBonusQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.VoidedQty).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<SalesOrderHeader>(entity =>
            {
                entity.HasKey(e => e.TransNo);

                entity.ToTable("SalesOrderHeader");

                entity.HasIndex(e => new { e.TransTypeCodeLevel1, e.TransDate, e.Status }, "IX_SalesOrderHeader_1");

                entity.Property(e => e.TransNo).HasMaxLength(50);

                entity.Property(e => e.BaseCurrencyCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BaseDiscount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.BaseGrossAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.BaseNetAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.BaseRebate).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BaseTaxes).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.BaseTotalAmountAfterRebate).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BaseTotalExpenses).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ComCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DeliveredDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.GrossAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.InvoiceDate).HasColumnType("date");

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.OrigTransNo).HasMaxLength(50);

                entity.Property(e => e.OrigTransTypeCodeLevel1).HasMaxLength(50);

                entity.Property(e => e.OrigTransTypeCodeLevel2).HasMaxLength(50);

                entity.Property(e => e.Podate)
                    .HasColumnType("date")
                    .HasColumnName("PODate");

                entity.Property(e => e.Pono)
                    .HasMaxLength(50)
                    .HasColumnName("PONo");

                entity.Property(e => e.Rebate).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SalesManId).HasColumnName("SalesManID");

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Taxes).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalAmountAfterRebate).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalExpenses).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalLandedCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.TransTypeCodeLevel1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TransTypeCodeLevel2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<SalesOrderHeaderView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SalesOrderHeader_View");

                entity.Property(e => e.BaseCurrencyCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BaseCurrencyNameL1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BaseCurrencyNameL2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BaseCurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.BaseDiscount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.BaseDiscountValue).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.BaseGrossAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.BaseNetAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.BaseRebate).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BaseRebateValue).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.BaseTaxes).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.BaseTaxesValue).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.BaseTotalAmountAfterRebate).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BaseTotalExpenses).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.CanceledBy).HasMaxLength(50);

                entity.Property(e => e.CanceledDateTime).HasMaxLength(50);

                entity.Property(e => e.ComCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CommercialRegistrationExpireDate).HasColumnType("date");

                entity.Property(e => e.CommercialRegistrationNo).HasMaxLength(50);

                entity.Property(e => e.CompanyName1).IsRequired();

                entity.Property(e => e.ContactPerson).HasMaxLength(50);

                entity.Property(e => e.CreditLimit).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.CreditPeriod)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CurrencyNameL1).HasMaxLength(50);

                entity.Property(e => e.CurrencyNameL2).HasMaxLength(50);

                entity.Property(e => e.CurrencySymbol)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerNameL1).HasMaxLength(200);

                entity.Property(e => e.CustomerNameL2).HasMaxLength(200);

                entity.Property(e => e.DeliveredDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.DiscountTypeDesc)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountValue).HasColumnType("decimal(38, 9)");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.GrossAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.InvoiceDate).HasColumnType("date");

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.InvoicedBy).HasMaxLength(50);

                entity.Property(e => e.InvoicedDateTime).HasMaxLength(50);

                entity.Property(e => e.MailAddress).HasMaxLength(50);

                entity.Property(e => e.MunicipalityApprovalExpireDate).HasColumnType("date");

                entity.Property(e => e.MunicipalityApprovalNo).HasMaxLength(50);

                entity.Property(e => e.Nationality).HasMaxLength(50);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.OrigTransNo).HasMaxLength(50);

                entity.Property(e => e.OrigTransTypeCodeLevel1).HasMaxLength(50);

                entity.Property(e => e.OrigTransTypeCodeLevel1Desc)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.OrigTransTypeCodeLevel2).HasMaxLength(50);

                entity.Property(e => e.OrigTransTypeCodeLevel2Desc)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNo).HasMaxLength(200);

                entity.Property(e => e.Pobox)
                    .HasMaxLength(50)
                    .HasColumnName("POBOX");

                entity.Property(e => e.Podate)
                    .HasColumnType("date")
                    .HasColumnName("PODate");

                entity.Property(e => e.Pono)
                    .HasMaxLength(50)
                    .HasColumnName("PONo");

                entity.Property(e => e.PostedBy).HasMaxLength(50);

                entity.Property(e => e.Rebate).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.RebateTypeDesc)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RebateValue).HasColumnType("decimal(38, 7)");

                entity.Property(e => e.SaleManNameL1).IsRequired();

                entity.Property(e => e.SaleManNameL2).IsRequired();

                entity.Property(e => e.SalesManId).HasColumnName("SalesManID");

                entity.Property(e => e.SponserId)
                    .HasMaxLength(50)
                    .HasColumnName("SponserID");

                entity.Property(e => e.SponsorIdexpireDate)
                    .HasColumnType("date")
                    .HasColumnName("SponsorIDExpireDate");

                entity.Property(e => e.StatusDesc)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StoName1).IsRequired();

                entity.Property(e => e.StoName2).IsRequired();

                entity.Property(e => e.Taxes).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TaxesTypeDesc)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TaxesValue).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.TotalAmountAfterRebate).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalExpenses).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalLandedCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalPaidAmount).HasColumnType("decimal(38, 3)");

                entity.Property(e => e.TotalRemainningAmount).HasColumnType("decimal(38, 3)");

                entity.Property(e => e.TotalReturnedAmount).HasColumnType("decimal(38, 3)");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.TransNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TransTypeCodeLevel1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TransTypeCodeLevel2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<SalesOrderReturnDetailsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SalesOrderReturnDetails_View");

                entity.Property(e => e.AverageCost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.AverageLandedCost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BaseDiscountForItem).HasColumnType("decimal(37, 8)");

                entity.Property(e => e.BaseDiscountForItemValue).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.BaseNetPrice).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.BaseTaxesForItem).HasColumnType("decimal(37, 8)");

                entity.Property(e => e.BaseTaxesForItemValue).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.BaseTotalLine).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.BaseUnitPrice).HasColumnType("decimal(37, 8)");

                entity.Property(e => e.BonusQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DeliveredBonusQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DeliveredQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DiscountForItem).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DiscountForItemValue).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.DiscountTypeDesc)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountValueFromHeader).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ExpensesForItem).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ExpensesValueFromHeader).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ItemNameL1).IsRequired();

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.LastSalesPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.NetPrice).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.OfferDefaultPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PriceListDefaultPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TaxesForItem).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TaxesForItemValue).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.TaxesTypeDesc)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TaxesValueFromHeader).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TotalLine).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.TransNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UnitCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UnitNameL1).HasMaxLength(50);

                entity.Property(e => e.UnitNameL2).HasMaxLength(50);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid).HasMaxLength(50);

                entity.Property(e => e.VoidedBonusQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.VoidedQty).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<SalesOrderReturnHeaderView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SalesOrderReturnHeader_View");

                entity.Property(e => e.BaseCurrencyCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BaseCurrencyNameL1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BaseCurrencyNameL2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BaseCurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.BaseDiscount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.BaseDiscountValue).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.BaseGrossAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.BaseNetAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.BaseTaxes).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.BaseTaxesValue).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.BaseTotalExpenses).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ComCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CommercialRegistrationExpireDate).HasColumnType("date");

                entity.Property(e => e.CommercialRegistrationNo).HasMaxLength(50);

                entity.Property(e => e.CompanyName1).IsRequired();

                entity.Property(e => e.ContactPerson).HasMaxLength(50);

                entity.Property(e => e.CreditLimit).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.CreditPeriod)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CurrencyNameL1).HasMaxLength(50);

                entity.Property(e => e.CurrencyNameL2).HasMaxLength(50);

                entity.Property(e => e.CurrencySymbol)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerNameL1).HasMaxLength(200);

                entity.Property(e => e.CustomerNameL2).HasMaxLength(200);

                entity.Property(e => e.DeliveredDateTime).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.DiscountTypeDesc)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountValue).HasColumnType("decimal(38, 9)");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.GrossAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.InvoiceDate).HasColumnType("date");

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.MailAddress).HasMaxLength(50);

                entity.Property(e => e.MunicipalityApprovalExpireDate).HasColumnType("date");

                entity.Property(e => e.MunicipalityApprovalNo).HasMaxLength(50);

                entity.Property(e => e.Nationality).HasMaxLength(50);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.OrigTransNo).HasMaxLength(50);

                entity.Property(e => e.OrigTransTypeCodeLevel1).HasMaxLength(50);

                entity.Property(e => e.OrigTransTypeCodeLevel1Desc)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.OrigTransTypeCodeLevel2).HasMaxLength(50);

                entity.Property(e => e.OrigTransTypeCodeLevel2Desc)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNo).HasMaxLength(200);

                entity.Property(e => e.Pobox)
                    .HasMaxLength(50)
                    .HasColumnName("POBOX");

                entity.Property(e => e.Podate)
                    .HasColumnType("date")
                    .HasColumnName("PODate");

                entity.Property(e => e.Pono)
                    .HasMaxLength(50)
                    .HasColumnName("PONo");

                entity.Property(e => e.PostedBy).HasMaxLength(50);

                entity.Property(e => e.SaleManNameL1).IsRequired();

                entity.Property(e => e.SaleManNameL2).IsRequired();

                entity.Property(e => e.SalesManId).HasColumnName("SalesManID");

                entity.Property(e => e.SponserId)
                    .HasMaxLength(50)
                    .HasColumnName("SponserID");

                entity.Property(e => e.SponsorIdexpireDate)
                    .HasColumnType("date")
                    .HasColumnName("SponsorIDExpireDate");

                entity.Property(e => e.StatusDesc)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StoName1).IsRequired();

                entity.Property(e => e.StoName2).IsRequired();

                entity.Property(e => e.Taxes).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TaxesTypeDesc)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TaxesValue).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalExpenses).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalLandedCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.TransNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TransTypeCodeLevel1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TransTypeCodeLevel2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<SalesPriceType>(entity =>
            {
                entity.HasKey(e => e.Sptcode);

                entity.Property(e => e.Sptcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SPTCode")
                    .IsFixedLength(true);

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(getdate())", false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<SecurityUser>(entity =>
            {
                entity.HasKey(e => e.UserCode);

                entity.HasIndex(e => e.LoginId, "LoginIDUnique_SecurityUsers")
                    .IsUnique();

                entity.Property(e => e.UserCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USER_CODE");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Lang)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LANG");

                entity.Property(e => e.LoginId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("login_id");

                entity.Property(e => e.MaxAllowDiscount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.MgrFlag).HasColumnName("mgr_flag");

                entity.Property(e => e.PassWord)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PASS_WORD");

                entity.Property(e => e.TreasuryId).HasColumnName("TreasuryID");

                entity.Property(e => e.UserName)
                    .IsUnicode(false)
                    .HasColumnName("USER_NAME");

                entity.Property(e => e.UserStatus).HasColumnName("USER_STATUS");

                entity.Property(e => e.UserType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USER_TYPE");
            });

            modelBuilder.Entity<SecurityUsersGroup>(entity =>
            {
                entity.ToTable("SecurityUsersGroup");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<Serial>(entity =>
            {
                entity.HasKey(e => new { e.ComCode, e.StoCode, e.TerminalCode, e.ModuleId, e.TransType1, e.TransType2, e.Year, e.Month, e.Day });

                entity.Property(e => e.ComCode).HasMaxLength(50);

                entity.Property(e => e.StoCode).HasMaxLength(50);

                entity.Property(e => e.TerminalCode).HasMaxLength(50);

                entity.Property(e => e.ModuleId).HasMaxLength(50);

                entity.Property(e => e.TransType1).HasMaxLength(50);

                entity.Property(e => e.TransType2).HasMaxLength(50);

                entity.Property(e => e.Year).HasMaxLength(50);

                entity.Property(e => e.Month).HasMaxLength(2);

                entity.Property(e => e.Day).HasMaxLength(2);

                entity.Property(e => e.HoldSerial).HasColumnName("Hold_serial");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(getdate())", false);

                entity.Property(e => e.InsertUserId)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUserID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(getdate())", false);

                entity.Property(e => e.Serial1).HasColumnName("Serial");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<SerialNoAttribute>(entity =>
            {
                entity.HasKey(e => e.AttributeId)
                    .HasName("PK_SerialNoAttributes_1");

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.AttributeNameL1).HasMaxLength(250);

                entity.Property(e => e.AttributeNameL2).HasMaxLength(250);

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<SerialNoAttributeValue>(entity =>
            {
                entity.HasKey(e => e.AttributeValueId);

                entity.Property(e => e.AttributeValueId).HasColumnName("AttributeValueID");

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<SerialNoUnitCost>(entity =>
            {
                entity.ToTable("SerialNoUnitCost");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.PrevCost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.SerialNo).HasMaxLength(50);

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<Shift>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.CashSerial });

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Cash).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Credit).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Custody).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DayCode).HasMaxLength(50);

                entity.Property(e => e.Diff).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.NewStartUserCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Payout).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ReturnValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UserCode).HasMaxLength(50);

                entity.Property(e => e.Visa).HasColumnType("decimal(18, 5)");
            });

            modelBuilder.Entity<ShiftsDay>(entity =>
            {
                entity.HasKey(e => e.DayCode);

                entity.ToTable("ShiftsDay");

                entity.Property(e => e.DayCode).HasMaxLength(50);

                entity.Property(e => e.ComCode).HasMaxLength(10);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.EndUserCode).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.StartUserCode).HasMaxLength(50);

                entity.Property(e => e.StoCode).HasMaxLength(10);
            });

            modelBuilder.Entity<SoldItemsAsTransactionView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SoldItemsAsTransaction_View");

                entity.Property(e => e.StoreCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TerminalId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Color).IsRequired();

                entity.Property(e => e.Description).IsRequired();
            });

            modelBuilder.Entity<StkAdjustmentDetailsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("StkAdjustmentDetails_View");

                entity.Property(e => e.DiffQty).HasColumnType("decimal(21, 5)");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.ItmInputCode).HasMaxLength(50);

                entity.Property(e => e.ModelCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NextBalance).HasColumnType("decimal(21, 5)");

                entity.Property(e => e.PreviouseBalance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.StoreName).IsRequired();

                entity.Property(e => e.TotalQtyCost).HasColumnType("decimal(37, 10)");

                entity.Property(e => e.TransMeasureUnit)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TransNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TransQty).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransTypeCodeLevel1)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.XAttributeValue)
                    .IsRequired()
                    .HasColumnName("X_AttributeValue");

                entity.Property(e => e.YAttributeValue)
                    .IsRequired()
                    .HasColumnName("Y_AttributeValue");
            });

            modelBuilder.Entity<StkAdjustmentView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("StkAdjustment_View");

                entity.Property(e => e.DifferenceBalance).HasColumnType("decimal(21, 5)");

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.ModelCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NameL1).IsRequired();

                entity.Property(e => e.NextBalance).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.OtherCostValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.PreviouseBalance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.StoreName).IsRequired();

                entity.Property(e => e.TotalItemsValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalQtyCost).HasColumnType("decimal(37, 10)");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.TransMeasureUnit)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TransNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TransTypeCodeLevel1)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TransTypeCodeLevel2)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.UnitName).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");

                entity.Property(e => e.XAttributeValue)
                    .IsRequired()
                    .HasColumnName("X_AttributeValue");

                entity.Property(e => e.YAttributeValue)
                    .IsRequired()
                    .HasColumnName("Y_AttributeValue");
            });

            modelBuilder.Entity<StockAdjustmentDetailsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("StockAdjustmentDetails_View");

                entity.Property(e => e.DiffQty).HasColumnType("decimal(21, 5)");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ItmCode)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.NextBalance).HasColumnType("decimal(21, 5)");

                entity.Property(e => e.OtherCostValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PreviouseBalance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Stkserial)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("STKSerial");

                entity.Property(e => e.StockAdjustmentTypeDesc)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.TotalQtyCost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TransMeasureUnit)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TransQty).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransTypeCodeLevel2)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.UnitNameL1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UnitNameL2)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<StockAdjustmentHeaderView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("StockAdjustmentHeader_View");

                entity.Property(e => e.ComCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CompanyName1).IsRequired();

                entity.Property(e => e.CompanyName2).IsRequired();

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.PostFlag)
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.Property(e => e.PostedBy).HasMaxLength(50);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.PostingDesc)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Stkserail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("STKSerail");

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.StockAdjustmentType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.StockAdjustmentTypeDesc)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.StoreName1).IsRequired();

                entity.Property(e => e.StoreName2).IsRequired();

                entity.Property(e => e.TotalCost).HasColumnType("decimal(38, 10)");

                entity.Property(e => e.TotalDiffCost).HasColumnType("decimal(38, 10)");

                entity.Property(e => e.TotalDiffQty).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.TotalItemsValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalNoOfItems).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.TotalQty).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<StockAdjustmentView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("StockAdjustment_View");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.PostFlag)
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.Property(e => e.PostedBy).HasMaxLength(50);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.StoreName).IsRequired();

                entity.Property(e => e.TotalItemsValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalNoOfItems).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.TransNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TransTypeCodeLevel1)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<StockBalanceView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("StockBalance_view");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryNameL1).IsRequired();

                entity.Property(e => e.GroupCode).HasMaxLength(3);

                entity.Property(e => e.GroupNameL1)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.LastPurchasePrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ModelCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModelDescription).IsRequired();

                entity.Property(e => e.NameL1).IsRequired();

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.StoreName).IsRequired();

                entity.Property(e => e.UnitCode).HasMaxLength(10);

                entity.Property(e => e.UnitName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UnitSize)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.XAttributeValue)
                    .IsRequired()
                    .HasColumnName("X_AttributeValue");

                entity.Property(e => e.YAttributeValue)
                    .IsRequired()
                    .HasColumnName("Y_AttributeValue");
            });

            modelBuilder.Entity<StockTakeDetail>(entity =>
            {
                entity.HasKey(e => new { e.TransNo, e.LineSerial });

                entity.Property(e => e.TransNo).HasMaxLength(50);

                entity.Property(e => e.SelectedModeCode).HasMaxLength(50);
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.HasKey(e => e.StoCode);

                entity.Property(e => e.StoCode).HasMaxLength(10);

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.CurrencyCode).HasMaxLength(50);

                entity.Property(e => e.DefaultPurchaseSubStoCode).HasMaxLength(10);

                entity.Property(e => e.DefaultSalesSubStoCode).HasMaxLength(10);

                entity.Property(e => e.InStockTake).HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(getdate())", false);

                entity.Property(e => e.MainStoCode).HasMaxLength(10);

                entity.Property(e => e.MainSub).HasMaxLength(1);

                entity.Property(e => e.NameL1).IsRequired();

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.SubTransferStoCode).HasMaxLength(10);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<StoreAccountCode>(entity =>
            {
                entity.HasKey(e => e.StoreCode)
                    .HasName("PK_STORE_A	CCOUNT_CODES");

                entity.ToTable("STORE_ACCOUNT_CODES");

                entity.Property(e => e.StoreCode).HasMaxLength(50);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(50)
                    .HasColumnName("Branch_Code");

                entity.Property(e => e.BranchId).HasColumnName("Branch_ID");

                entity.Property(e => e.CashDiffAccCode)
                    .HasMaxLength(50)
                    .HasColumnName("CashDiff_Acc_Code");

                entity.Property(e => e.CashDiffAccId).HasColumnName("CashDiff_Acc_ID");

                entity.Property(e => e.CashDiffCostCenterCode)
                    .HasMaxLength(50)
                    .HasColumnName("CashDiff_Cost_Center_Code");

                entity.Property(e => e.CashDiffCostCenterId).HasColumnName("CashDiff_Cost_Center_ID");

                entity.Property(e => e.CogsAccCode)
                    .HasMaxLength(50)
                    .HasColumnName("COGS_Acc_Code");

                entity.Property(e => e.CogsAccId).HasColumnName("COGS_Acc_ID");

                entity.Property(e => e.CogsCostCenterCode)
                    .HasMaxLength(50)
                    .HasColumnName("COGS_Cost_Center_Code");

                entity.Property(e => e.CogsCostCenterId).HasColumnName("COGS_Cost_Center_ID");

                entity.Property(e => e.CouponAccCode)
                    .HasMaxLength(50)
                    .HasColumnName("Coupon_Acc_Code");

                entity.Property(e => e.CouponAccId).HasColumnName("Coupon_Acc_ID");

                entity.Property(e => e.CouponCostCenterCode)
                    .HasMaxLength(50)
                    .HasColumnName("Coupon_Cost_Center_Code");

                entity.Property(e => e.CouponCostCenterId).HasColumnName("Coupon_Cost_Center_ID");

                entity.Property(e => e.CreditCardAccCode)
                    .HasMaxLength(50)
                    .HasColumnName("CreditCard_Acc_Code");

                entity.Property(e => e.CreditCardAccId).HasColumnName("CreditCard_Acc_ID");

                entity.Property(e => e.CreditCardCostCenterCode)
                    .HasMaxLength(50)
                    .HasColumnName("CreditCard_Cost_Center_Code");

                entity.Property(e => e.CreditCardCostCenterId).HasColumnName("CreditCard_Cost_Center_ID");

                entity.Property(e => e.CurrencyId).HasColumnName("Currency_ID");

                entity.Property(e => e.DebitAccCode)
                    .HasMaxLength(50)
                    .HasColumnName("Debit_Acc_Code");

                entity.Property(e => e.DebitAccId).HasColumnName("Debit_Acc_ID");

                entity.Property(e => e.DebitCostCenterCode)
                    .HasMaxLength(50)
                    .HasColumnName("Debit_Cost_Center_Code");

                entity.Property(e => e.DebitCostCenterId).HasColumnName("Debit_Cost_Center_ID");

                entity.Property(e => e.DeliveryFeesAccCode)
                    .HasMaxLength(50)
                    .HasColumnName("DeliveryFees_Acc_Code");

                entity.Property(e => e.DeliveryFeesAccId).HasColumnName("DeliveryFees_Acc_ID");

                entity.Property(e => e.DeliveryFeesCostCenterCode)
                    .HasMaxLength(50)
                    .HasColumnName("DeliveryFees_Cost_Center_Code");

                entity.Property(e => e.DeliveryFeesCostCenterId).HasColumnName("DeliveryFees_Cost_Center_ID");

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(50)
                    .HasColumnName("Department_Code");

                entity.Property(e => e.DepartmentId).HasColumnName("Department_ID");

                entity.Property(e => e.DiscountAccCode)
                    .HasMaxLength(50)
                    .HasColumnName("Discount_Acc_Code");

                entity.Property(e => e.DiscountAccId).HasColumnName("Discount_Acc_ID");

                entity.Property(e => e.DiscountCostCenterCode)
                    .HasMaxLength(50)
                    .HasColumnName("Discount_Cost_Center_Code");

                entity.Property(e => e.DiscountCostCenterId).HasColumnName("Discount_Cost_Center_ID");

                entity.Property(e => e.DocumentTypeId).HasColumnName("Document_Type_ID");

                entity.Property(e => e.ExpAccCode)
                    .HasMaxLength(50)
                    .HasColumnName("Exp_Acc_Code");

                entity.Property(e => e.ExpAccId).HasColumnName("Exp_Acc_ID");

                entity.Property(e => e.ExpCostCenterCode)
                    .HasMaxLength(50)
                    .HasColumnName("Exp_Cost_Center_Code");

                entity.Property(e => e.ExpCostCenterId).HasColumnName("Exp_Cost_Center_ID");

                entity.Property(e => e.ForeignExchangeGainAndLossAccCode)
                    .HasMaxLength(50)
                    .HasColumnName("Foreign_Exchange_Gain_And_Loss_Acc_Code");

                entity.Property(e => e.ForeignExchangeGainAndLossAccId).HasColumnName("Foreign_Exchange_Gain_And_Loss_Acc_ID");

                entity.Property(e => e.ForeignExchangeGainAndLossCostCenterCode)
                    .HasMaxLength(50)
                    .HasColumnName("Foreign_Exchange_Gain_And_Loss_Cost_Center_Code");

                entity.Property(e => e.ForeignExchangeGainAndLossCostCenterId).HasColumnName("Foreign_Exchange_Gain_And_Loss_Cost_Center_ID");

                entity.Property(e => e.GoodsOnDeliveryAccCode)
                    .HasMaxLength(50)
                    .HasColumnName("Goods_On_Delivery_Acc_Code");

                entity.Property(e => e.GoodsOnDeliveryAccId).HasColumnName("Goods_On_Delivery_Acc_ID");

                entity.Property(e => e.GoodsOnDeliveryCostCenterCode)
                    .HasMaxLength(50)
                    .HasColumnName("Goods_On_Delivery_Cost_Center_Code");

                entity.Property(e => e.GoodsOnDeliveryCostCenterId).HasColumnName("Goods_On_Delivery_Cost_Center_ID");

                entity.Property(e => e.JournalTypeId).HasColumnName("Journal_Type_ID");

                entity.Property(e => e.NotesPayableAccCode)
                    .HasMaxLength(50)
                    .HasColumnName("Notes_Payable_Acc_Code");

                entity.Property(e => e.NotesPayableAccId).HasColumnName("Notes_Payable_Acc_ID");

                entity.Property(e => e.NotesPayableCostCenterCode)
                    .HasMaxLength(50)
                    .HasColumnName("Notes_Payable_Cost_Center_Code");

                entity.Property(e => e.NotesPayableCostCenterId).HasColumnName("Notes_Payable_Cost_Center_ID");

                entity.Property(e => e.NotesPayableJournalTypeId).HasColumnName("NOTES_PAYABLE_Journal_Type_ID");

                entity.Property(e => e.NotesReceivableAccCode)
                    .HasMaxLength(50)
                    .HasColumnName("Notes_Receivable_Acc_Code");

                entity.Property(e => e.NotesReceivableAccId).HasColumnName("Notes_Receivable_Acc_ID");

                entity.Property(e => e.NotesReceivableCostCenterCode)
                    .HasMaxLength(50)
                    .HasColumnName("Notes_Receivable_Cost_Center_Code");

                entity.Property(e => e.NotesReceivableCostCenterId).HasColumnName("Notes_Receivable_Cost_Center_ID");

                entity.Property(e => e.NotesReceivableJournalTypeId).HasColumnName("NOTES_RECEIVABLE_Journal_Type_ID");

                entity.Property(e => e.PayableAccCode)
                    .HasMaxLength(50)
                    .HasColumnName("Payable_acc_Code");

                entity.Property(e => e.PayableAccId).HasColumnName("Payable_Acc_ID");

                entity.Property(e => e.PayableCostCenterCode)
                    .HasMaxLength(50)
                    .HasColumnName("Payable_Cost_Center_Code");

                entity.Property(e => e.PayableCostCenterId).HasColumnName("Payable_Cost_Center_ID");

                entity.Property(e => e.PrePaidAccCode)
                    .HasMaxLength(50)
                    .HasColumnName("PrePaid_Acc_Code");

                entity.Property(e => e.PrePaidAccId).HasColumnName("PrePaid_Acc_ID");

                entity.Property(e => e.PrepaidCostCenterCode)
                    .HasMaxLength(50)
                    .HasColumnName("Prepaid_Cost_Center_Code");

                entity.Property(e => e.PrepaidCostCenterId).HasColumnName("Prepaid_Cost_Center_ID");

                entity.Property(e => e.PurchaseJournalTypeId).HasColumnName("PURCHASE_Journal_Type_ID");

                entity.Property(e => e.SalesAccCode)
                    .HasMaxLength(50)
                    .HasColumnName("Sales_Acc_Code");

                entity.Property(e => e.SalesAccId).HasColumnName("Sales_Acc_ID");

                entity.Property(e => e.SalesCostCenterCode)
                    .HasMaxLength(50)
                    .HasColumnName("Sales_Cost_Center_Code");

                entity.Property(e => e.SalesCostCenterId).HasColumnName("Sales_Cost_Center_ID");

                entity.Property(e => e.SalesTaxAccCode)
                    .HasMaxLength(50)
                    .HasColumnName("SalesTax_Acc_Code");

                entity.Property(e => e.SalesTaxAccId).HasColumnName("SalesTax_Acc_ID");

                entity.Property(e => e.SalesTaxCostCenterCode)
                    .HasMaxLength(50)
                    .HasColumnName("SalesTax_Cost_Center_Code");

                entity.Property(e => e.SalesTaxCostCenterId).HasColumnName("SalesTax_Cost_Center_ID");

                entity.Property(e => e.StockDiffAccCode)
                    .HasMaxLength(50)
                    .HasColumnName("StockDiff_acc_Code");

                entity.Property(e => e.StockDiffAccId).HasColumnName("StockDiff_Acc_ID");

                entity.Property(e => e.StockDiffCostCenterCode)
                    .HasMaxLength(50)
                    .HasColumnName("StockDiff_Cost_Center_Code");

                entity.Property(e => e.StockDiffCostCenterId).HasColumnName("StockDiff_Cost_Center_ID");

                entity.Property(e => e.StockDifferenceJournalTypeId).HasColumnName("STOCK_DIFFERENCE_Journal_Type_ID");

                entity.Property(e => e.StoreAccCode)
                    .HasMaxLength(50)
                    .HasColumnName("Store_Acc_Code");

                entity.Property(e => e.StoreAccId).HasColumnName("Store_Acc_ID");

                entity.Property(e => e.StoreCostCenterCode)
                    .HasMaxLength(50)
                    .HasColumnName("Store_Cost_Center_Code");

                entity.Property(e => e.StoreCostCenterId).HasColumnName("Store_Cost_Center_ID");

                entity.Property(e => e.TreasureAccCode)
                    .HasMaxLength(50)
                    .HasColumnName("Treasure_Acc_Code");

                entity.Property(e => e.TreasureAccId).HasColumnName("Treasure_Acc_ID");

                entity.Property(e => e.TreasureCostCenterCode)
                    .HasMaxLength(50)
                    .HasColumnName("Treasure_Cost_Center_Code");

                entity.Property(e => e.TreasureCostCenterId).HasColumnName("Treasure_Cost_Center_ID");
            });

            modelBuilder.Entity<StoreVoucherDetail>(entity =>
            {
                entity.HasKey(e => new { e.VoucherNo, e.LineSerial });

                entity.Property(e => e.VoucherNo).HasMaxLength(50);

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.NextBalance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PreviousBalance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UnitCode).HasMaxLength(50);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");
            });

            modelBuilder.Entity<StoreVoucherDetailsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("StoreVoucherDetails_View");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryNameL1).IsRequired();

                entity.Property(e => e.GroupCode).HasMaxLength(3);

                entity.Property(e => e.GroupNameL1)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.ModelCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModelDescription).IsRequired();

                entity.Property(e => e.NextBalance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PreviousBalance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UnitCode).HasMaxLength(50);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UnitNameL1).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");

                entity.Property(e => e.VoucherNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.XAttributeValue)
                    .IsRequired()
                    .HasColumnName("X_AttributeValue");

                entity.Property(e => e.YAttributeValue)
                    .IsRequired()
                    .HasColumnName("Y_AttributeValue");
            });

            modelBuilder.Entity<StoreVoucherHeader>(entity =>
            {
                entity.HasKey(e => e.VoucherNo);

                entity.ToTable("StoreVoucherHeader");

                entity.Property(e => e.VoucherNo).HasMaxLength(50);

                entity.Property(e => e.BeneficiaryCode).HasMaxLength(50);

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.StoCode).HasMaxLength(50);

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");

                entity.Property(e => e.VoucherTypeId).HasColumnName("VoucherTypeID");
            });

            modelBuilder.Entity<StoreVoucherHeaderBeneficiaryDetail>(entity =>
            {
                entity.HasKey(e => new { e.VoucherNo, e.LineSerial });

                entity.Property(e => e.VoucherNo).HasMaxLength(50);

                entity.Property(e => e.BeneficiaryCode).HasMaxLength(50);

                entity.Property(e => e.BeneficiaryDetailCode).HasMaxLength(50);

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");
            });

            modelBuilder.Entity<StoreVoucherHeaderView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("StoreVoucherHeader_View");

                entity.Property(e => e.BeneficiaryCode).HasMaxLength(50);

                entity.Property(e => e.BeneficiaryDetailCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BeneficiaryTypeDesc)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.PostFlagDesc)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostedBy).HasMaxLength(50);

                entity.Property(e => e.StoCode).HasMaxLength(50);

                entity.Property(e => e.StoreNameL1).IsRequired();

                entity.Property(e => e.TotalCost).HasColumnType("decimal(38, 8)");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");

                entity.Property(e => e.VoucherDesc)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.VoucherNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.VoucherTypeCode).HasMaxLength(10);

                entity.Property(e => e.VoucherTypeId).HasColumnName("VoucherTypeID");
            });

            modelBuilder.Entity<StoreVouchersType>(entity =>
            {
                entity.HasKey(e => e.VoucherTypeId);

                entity.ToTable("StoreVouchersType");

                entity.Property(e => e.VoucherTypeId).HasColumnName("VoucherTypeID");

                entity.Property(e => e.AccountCode).HasMaxLength(50);

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.CostCenterCode).HasMaxLength(50);

                entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");

                entity.Property(e => e.VoucherTypeCode).HasMaxLength(10);
            });

            modelBuilder.Entity<SubStoreItemTransactionTemp>(entity =>
            {
                entity.ToTable("SubStoreItemTransactionTemp");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComCode).HasMaxLength(50);

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.Status).HasComment("0 ==> Composing, 1 ==> Saved");

                entity.Property(e => e.StoCode).HasMaxLength(50);

                entity.Property(e => e.TermCode).HasMaxLength(50);

                entity.Property(e => e.TransTypeCodeLeve1).HasMaxLength(10);

                entity.Property(e => e.TransTypeCodeLeve2).HasMaxLength(10);
            });

            modelBuilder.Entity<SubStoreItemTransactionTempView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SubStoreItemTransactionTemp_View");

                entity.Property(e => e.BonusQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ItemNameL1).IsRequired();

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SalesUnitNameL1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SmallSubStoreQty).HasColumnType("decimal(38, 3)");

                entity.Property(e => e.TransQty).HasColumnType("decimal(20, 5)");
            });

            modelBuilder.Entity<SystemAuditing>(entity =>
            {
                entity.HasKey(e => e.AuditNo);

                entity.ToTable("SystemAuditing");

                entity.HasIndex(e => new { e.AuditType, e.ReferenceNo }, "IX_SystemAuditing_1");

                entity.Property(e => e.AuditNo).HasMaxLength(50);

                entity.Property(e => e.AuditingDatetime).HasColumnType("datetime");

                entity.Property(e => e.FormName).HasMaxLength(50);

                entity.Property(e => e.ReferenceNo).HasMaxLength(50);

                entity.Property(e => e.StoCode).HasMaxLength(50);

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<SystemContact>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.Mail)
                    .HasMaxLength(50)
                    .HasColumnName("mail");

                entity.Property(e => e.Type)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1 = SystemUser;2=Customer;3=Vendor");
            });

            modelBuilder.Entity<SystemLog>(entity =>
            {
                entity.HasKey(e => e.LogNo);

                entity.ToTable("SystemLog");

                entity.Property(e => e.LogNo).HasMaxLength(50);

                entity.Property(e => e.StoCode).HasMaxLength(50);

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<SystemParameter>(entity =>
            {
                entity.ToTable("SystemParameter");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ComCode)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.SpShow)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Table>(entity =>
            {
                entity.Property(e => e.TableId).HasColumnName("TableID");

                entity.Property(e => e.AccessTime).HasColumnType("datetime");

                entity.Property(e => e.Active).HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrentSalesNo)
                    .HasMaxLength(50)
                    .HasColumnName("currentSalesNo");

                entity.Property(e => e.CurrentUser).HasMaxLength(50);

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.TableName).HasMaxLength(50);
            });

            modelBuilder.Entity<TablesTemp1>(entity =>
            {
                entity.HasKey(e => e.TableId);

                entity.ToTable("TablesTemp_1");

                entity.Property(e => e.TableId)
                    .ValueGeneratedNever()
                    .HasColumnName("TableID");

                entity.Property(e => e.AccessTime).HasColumnType("datetime");

                entity.Property(e => e.Active).HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrentSalesNo).HasColumnName("currentSalesNo");

                entity.Property(e => e.CurrentUser).HasMaxLength(50);

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.TableName).HasMaxLength(50);
            });

            modelBuilder.Entity<TaxTemplate>(entity =>
            {
                entity.ToTable("TaxTemplate");

                entity.Property(e => e.Id).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(getdate())", false);

                entity.Property(e => e.Rate).HasColumnType("numeric(16, 2)");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.TaxTcode)
                    .HasMaxLength(50)
                    .HasColumnName("TaxTCode");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.TaxTemplates)
                    .HasForeignKey(d => d.Type)
                    .HasConstraintName("FK_TaxTemplate_TaxTypes");
            });

            modelBuilder.Entity<TaxType>(entity =>
            {
                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(getdate())", false);

                entity.Property(e => e.NameL1).IsRequired();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TaxCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<TempTransTable>(entity =>
            {
                entity.ToTable("TempTransTable");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.StoCode).HasMaxLength(50);

                entity.Property(e => e.Total).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.TransTypeCode).HasMaxLength(5);

                entity.Property(e => e.TrnsQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UnitName).HasMaxLength(500);

                entity.Property(e => e.UnitType).HasMaxLength(5);

                entity.Property(e => e.UserCode).HasMaxLength(50);
            });

            modelBuilder.Entity<Terminal>(entity =>
            {
                entity.HasKey(e => e.TermCode)
                    .HasName("PK_Terminals_1");

                entity.Property(e => e.TermCode).ValueGeneratedNever();

                entity.Property(e => e.LastUdpate)
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(getdate())", false);

                entity.Property(e => e.NameL1).IsRequired();

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<TerminalAccountCode>(entity =>
            {
                entity.HasKey(e => e.TerminalCode);

                entity.ToTable("TERMINAL_ACCOUNT_CODES");

                entity.Property(e => e.TerminalCode).ValueGeneratedNever();

                entity.Property(e => e.CashDiffAccCode)
                    .HasMaxLength(50)
                    .HasColumnName("CashDiff_Acc_Code");

                entity.Property(e => e.CashDiffAccId).HasColumnName("CashDiff_Acc_ID");

                entity.Property(e => e.CogsAccCode)
                    .HasMaxLength(50)
                    .HasColumnName("COGS_Acc_Code");

                entity.Property(e => e.CogsAccId).HasColumnName("COGS_Acc_ID");

                entity.Property(e => e.CreditCardAccCode)
                    .HasMaxLength(50)
                    .HasColumnName("CreditCard_Acc_Code");

                entity.Property(e => e.CreditCardAccId).HasColumnName("CreditCard_Acc_ID");

                entity.Property(e => e.DebitAccCode)
                    .HasMaxLength(50)
                    .HasColumnName("Debit_Acc_Code");

                entity.Property(e => e.DebitAccId).HasColumnName("Debit_Acc_ID");

                entity.Property(e => e.DeliveryFeesAccCode)
                    .HasMaxLength(50)
                    .HasColumnName("DeliveryFees_Acc_Code");

                entity.Property(e => e.DeliveryFeesAccId).HasColumnName("DeliveryFees_Acc_ID");

                entity.Property(e => e.DiscountAccCode)
                    .HasMaxLength(50)
                    .HasColumnName("Discount_Acc_Code");

                entity.Property(e => e.DiscountAccId).HasColumnName("Discount_Acc_ID");

                entity.Property(e => e.SalesAccCode)
                    .HasMaxLength(50)
                    .HasColumnName("Sales_Acc_Code");

                entity.Property(e => e.SalesAccId).HasColumnName("Sales_Acc_ID");

                entity.Property(e => e.SalesTaxAccCode)
                    .HasMaxLength(50)
                    .HasColumnName("SalesTax_Acc_Code");

                entity.Property(e => e.SalesTaxAccId).HasColumnName("SalesTax_Acc_ID");

                entity.Property(e => e.StoreAccCode)
                    .HasMaxLength(50)
                    .HasColumnName("Store_Acc_Code");

                entity.Property(e => e.StoreAccId).HasColumnName("Store_Acc_ID");

                entity.Property(e => e.TreasureAccCode)
                    .HasMaxLength(50)
                    .HasColumnName("Treasure_Acc_Code");

                entity.Property(e => e.TreasureAccId).HasColumnName("Treasure_Acc_ID");
            });

            modelBuilder.Entity<Terminology>(entity =>
            {
                entity.ToTable("Terminology");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasKey(e => e.ItemTransId);

                entity.HasIndex(e => new { e.DocumentType, e.UpdateDate }, "IX_Transactions_1");

                entity.HasIndex(e => e.UpdateDate, "IX_Transactions_2");

                entity.HasIndex(e => new { e.StoreCode, e.ItemSerial, e.UpdateDate }, "IX_Transactions_3");

                entity.HasIndex(e => new { e.DocumentType, e.UpdateDate }, "IX_Transactions_4");

                entity.HasIndex(e => new { e.ItemSerial, e.UpdateDate }, "IX_Transactions_5");

                entity.HasIndex(e => e.DocumentSerial, "IX_Transactions_6");

                entity.HasIndex(e => e.DocumentSerial, "IX_Transactions_7");

                entity.Property(e => e.DocumentSerial).HasMaxLength(50);

                entity.Property(e => e.MainStoCode).HasMaxLength(50);

                entity.Property(e => e.NextBalance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PrevBalance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.StoreCode).HasMaxLength(10);

                entity.Property(e => e.SubStoCode).HasMaxLength(50);

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.TrnsMonth).HasDefaultValueSql("(datepart(month,getdate()))");

                entity.Property(e => e.TrnsQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TrnsYear).HasDefaultValueSql("(datepart(year,getdate()))");

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.UnitSalesPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransactionsEvent>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.ToDate).HasColumnType("date");

                entity.Property(e => e.TransNo).HasMaxLength(50);

                entity.Property(e => e.TransTypeCodeLevel1).HasMaxLength(5);

                entity.Property(e => e.TransTypeCodeLevel2).HasMaxLength(5);
            });

            modelBuilder.Entity<TransactionsTemp>(entity =>
            {
                entity.HasKey(e => e.ItemTransId);

                entity.ToTable("TransactionsTemp");

                entity.Property(e => e.DocumentSerial).HasMaxLength(50);

                entity.Property(e => e.DocumentType).HasComment("1=opening balance ; 2 = Purchase ; 3 = purchase Return ; 4 = transfer issue ; 5 = transfer receive ; 6 = stock adjustment add ; 7 = stock adjustment subtract ; 8 = sales ; 9 = sales Return");

                entity.Property(e => e.MainStoCode).HasMaxLength(50);

                entity.Property(e => e.NextBalance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PrevBalance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.StoreCode)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.TransType).HasComment("1=add;2=subtract");

                entity.Property(e => e.TrnsMonth).HasDefaultValueSql("(datepart(month,getdate()))");

                entity.Property(e => e.TrnsQty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TrnsYear).HasDefaultValueSql("(datepart(year,getdate()))");

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UnitSalesPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransferDetailsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TransferDetails_View");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryNameL1).IsRequired();

                entity.Property(e => e.DelivQty).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.GroupCode).HasMaxLength(3);

                entity.Property(e => e.GroupNameL1)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ItemTransferStatus)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.ModelCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModelDescription).IsRequired();

                entity.Property(e => e.NotDelivQty).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.OtherCostValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.RequisitionNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TotalQtyCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransMeasureUnit)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TransQty).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransferDesc)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Traserial)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TRASerial");

                entity.Property(e => e.UnitNameL1).HasMaxLength(50);

                entity.Property(e => e.UnitNameL2).HasMaxLength(50);

                entity.Property(e => e.XAttributeValue)
                    .IsRequired()
                    .HasColumnName("X_AttributeValue");

                entity.Property(e => e.YAttributeValue)
                    .IsRequired()
                    .HasColumnName("Y_AttributeValue");
            });

            modelBuilder.Entity<TransferHeaderView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TransferHeader_View");

                entity.Property(e => e.ComCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CompanyNameL1).IsRequired();

                entity.Property(e => e.CompanyNameL2).IsRequired();

                entity.Property(e => e.FromStoCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.FromStoreNameL1).IsRequired();

                entity.Property(e => e.FromStoreNameL2).IsRequired();

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.InvoiceDate).HasColumnType("date");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.PostFlag)
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.Property(e => e.PostedBy).HasMaxLength(50);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.PostingDesc)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RequisitionNo).HasMaxLength(50);

                entity.Property(e => e.ToStoCode)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ToStoreNameL1).IsRequired();

                entity.Property(e => e.ToStoreNameL2).IsRequired();

                entity.Property(e => e.TotalItemsValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalNoOfItems).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.TotalOthersValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalQty).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.TransferStatus)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Traserial)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TRASerial");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TransferRecieveDetailsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TransferRecieveDetails_View");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryNameL1).IsRequired();

                entity.Property(e => e.GroupCode).HasMaxLength(3);

                entity.Property(e => e.GroupNameL1)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.ItmSalesPrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ModelCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModelDescription).IsRequired();

                entity.Property(e => e.NotDeliverQty).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.OtherCostValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalQtyCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransMeasureUnit)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TransQty).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransferQty).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Traserial)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TRASerial");

                entity.Property(e => e.UnitNameL1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UnitNameL2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.XAttributeValue)
                    .IsRequired()
                    .HasColumnName("X_AttributeValue");

                entity.Property(e => e.YAttributeValue)
                    .IsRequired()
                    .HasColumnName("Y_AttributeValue");
            });

            modelBuilder.Entity<TransferRecieveHeaderView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TransferRecieveHeader_View");

                entity.Property(e => e.ComCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ComName1).IsRequired();

                entity.Property(e => e.ComName2).IsRequired();

                entity.Property(e => e.FromStoCode)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.FromStoreNameL1).IsRequired();

                entity.Property(e => e.FromStoreNameL2).IsRequired();

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.InvoiceDate).HasColumnType("date");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.PostFlag)
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.PostingDesc)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RequisitionNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ToStoCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ToStoreNameL1).IsRequired();

                entity.Property(e => e.ToStoreNameL2).IsRequired();

                entity.Property(e => e.TotalItemsValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalNoOfItems).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.TotalOthersValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalQty).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.TransferIssueSerial).HasMaxLength(50);

                entity.Property(e => e.Traserial)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TRASerial");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TransferView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Transfer_View");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryNameL1).IsRequired();

                entity.Property(e => e.ComCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CompanyNameL1).IsRequired();

                entity.Property(e => e.DelivQty).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.FromStoreNameL1).IsRequired();

                entity.Property(e => e.FromStoreNameL2).IsRequired();

                entity.Property(e => e.GroupCode).HasMaxLength(3);

                entity.Property(e => e.GroupNameL1)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.InvoiceDate).HasColumnType("date");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.ItemNameL1).IsRequired();

                entity.Property(e => e.ItemTransferStatus)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.ItmSalesPrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ModelCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModelDescription).IsRequired();

                entity.Property(e => e.NotDelivQty).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.OtherCostValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.PostFlag)
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.Property(e => e.PostedBy).HasMaxLength(50);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.PostingDesc)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RequisitionNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReturnStoreCode)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ToStoreNameL1).IsRequired();

                entity.Property(e => e.ToStoreNameL2).IsRequired();

                entity.Property(e => e.TotalItemsValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalNoOfItems).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.TotalOthersValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalQtyCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.TransMeasureUnit)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TransNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TransQty).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TransferDesc)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TransferStatus)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.UnitNameL1).HasMaxLength(50);

                entity.Property(e => e.UnitNameL2).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.XAttributeValue)
                    .IsRequired()
                    .HasColumnName("X_AttributeValue");

                entity.Property(e => e.YAttributeValue)
                    .IsRequired()
                    .HasColumnName("Y_AttributeValue");
            });

            modelBuilder.Entity<Treasury>(entity =>
            {
                entity.ToTable("Treasury");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Credit).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Debit).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.GlaccountCode)
                    .HasMaxLength(50)
                    .HasColumnName("GLAccountCode");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid).HasColumnName("InsertUID");
            });

            modelBuilder.Entity<TreasuryStatement>(entity =>
            {
                entity.ToTable("TreasuryStatement");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Credit).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Debit).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DocumentNo).HasMaxLength(50);

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.TransType).HasComment("0=Opening Balance; 1 = Cash Sales ; 2 = Cash Sales Return ; 3 = Payment ; 4 = Refund");

                entity.Property(e => e.TreasuryId).HasColumnName("TreasuryID");
            });

            modelBuilder.Entity<UserCompany>(entity =>
            {
                entity.HasKey(e => new { e.ComCode, e.UserCode });

                entity.ToTable("UserCompany");

                entity.Property(e => e.ComCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserCompanyStore>(entity =>
            {
                entity.HasKey(e => new { e.ComCode, e.UserCode, e.StoCode });

                entity.ToTable("UserCompanyStore");

                entity.Property(e => e.ComCode).HasMaxLength(20);

                entity.Property(e => e.UserCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoCode)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<UserFunctionsPermission>(entity =>
            {
                entity.HasIndex(e => new { e.UserCode, e.FunctionPermissionId }, "IX_UserFunctionsPermissions")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FunctionPermissionId).HasColumnName("FunctionPermissionID");

                entity.Property(e => e.UserCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountCode).HasMaxLength(50);

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Balance)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BankAccount).HasMaxLength(50);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ComCode)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CurrCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("((1))")
                    .IsFixedLength(true);

                entity.Property(e => e.LastUdate)
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(getdate())", false);

                entity.Property(e => e.MainSub)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('M')");

                entity.Property(e => e.MainVendorId).HasColumnName("MainVendorID");

                entity.Property(e => e.NameL1).IsRequired();

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))")
                    .IsFixedLength(true);

                entity.Property(e => e.Telephone1).HasMaxLength(50);

                entity.Property(e => e.Telephone2).HasMaxLength(50);

                entity.Property(e => e.TotalCredit)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalDebit)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalPurchases).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<VendorStatement>(entity =>
            {
                entity.ToTable("VendorStatement");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Credit).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Debit).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DocumentNo).HasMaxLength(50);

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.VenId).HasColumnName("VenID");
            });

            modelBuilder.Entity<VendorStatementView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VendorStatement_View");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Cb).HasColumnName("CB");

                entity.Property(e => e.Credit).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength(true);

                entity.Property(e => e.CurrencyName).HasMaxLength(50);

                entity.Property(e => e.Debit).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.Ob).HasColumnName("OB");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.TransDateBalance).HasColumnType("decimal(38, 3)");

                entity.Property(e => e.TransTypeDesc)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.VenId).HasColumnName("VenID");

                entity.Property(e => e.VendorName).IsRequired();
            });

            modelBuilder.Entity<ViewItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Items");

                entity.Property(e => e.AverageCost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ItmCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastPurchasePrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LastSalesPrice).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<WorkOrderDetailsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("WorkOrderDetails_View");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.ItemNameL1).IsRequired();

                entity.Property(e => e.ItmCode).HasMaxLength(250);

                entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TransNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TransQty).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.UnitCode)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UnitNameL1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UnitNameL2)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<WorkOrderHeaderView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("WorkOrderHeader_View");

                entity.Property(e => e.ComCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CompanyName1).IsRequired();

                entity.Property(e => e.CompanyName2).IsRequired();

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUid)
                    .HasMaxLength(50)
                    .HasColumnName("InsertUID");

                entity.Property(e => e.PostFlag)
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.PostingDesc)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RecievedFlagDesc)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.StoCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.StoreName1).IsRequired();

                entity.Property(e => e.StoreName2).IsRequired();

                entity.Property(e => e.TotalCost).HasColumnType("decimal(38, 8)");

                entity.Property(e => e.TotalItemsValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalNoOfItems).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.TotalQty).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.TransNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUid)
                    .HasMaxLength(50)
                    .HasColumnName("UpdateUID");

                entity.Property(e => e.WorkOrderType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.WorkOrderTypeDesc)
                    .HasMaxLength(17)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Xreport>(entity =>
            {
                entity.HasKey(e => new { e.ShId, e.ItmSerial, e.TerminalId });

                entity.ToTable("Xreport");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.AverageCost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.ItmGroupCode)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ItmQty).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ItmSalesDesc)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ItmTaxValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ItmValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.StoCode).HasMaxLength(10);
            });

            modelBuilder.Entity<XreportView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Xreport_view");

                entity.Property(e => e.GroupName).HasMaxLength(200);

                entity.Property(e => e.ItmQty).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ItmValue).HasColumnType("decimal(38, 3)");

                entity.Property(e => e.NameL1).IsRequired();

                entity.Property(e => e.ShId).HasColumnName("ShID");

                entity.Property(e => e.SoldItemType)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Xx>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("XX");

                entity.Property(e => e.ArrtibuteValueId).HasColumnName("ArrtibuteValueID");

                entity.Property(e => e.AttributeDesc)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.AttributeValueDesc).HasMaxLength(255);

                entity.Property(e => e.ModelCode).HasMaxLength(255);

                entity.Property(e => e.ModelId).HasColumnName("ModelID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
