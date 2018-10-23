namespace n_language
{
    public enum LanguageSel
    {
        NoneInit,
        English,
        Chinese,
    }

    //ls_xxx : Language String xxxx         
    //sel: select

    public class Clanguage
    {
        public static LanguageSel lang= LanguageSel.NoneInit;
		//company
		public static string ls_legal_affairs;//LegalAffairs
		public static string ls_environment_safety;//environment
		public static string ls_require;//Require
		public static string ls_training;//Training
		public static string ls_communicate;//Communicate
		public static string ls_service;//Service
		public static string ls_task;//Task
		public static string ls_question;//Question
		public static string ls_business;
		public static string ls_develop;
		public static string ls_project;
		public static string ls_materials;
		public static string ls_fiscal;
		public static string ls_personnel;
		public static string ls_stock;
		public static string ls_group;
		public static string ls_edit;
		public static string ls_organization;
		public static string ls_record;
		public static string ls_workspace;
		public static string ls_company;
		//Public 
		public static string ls_colon;
        public static string ls_serial_port;
        public static string ls_error;
        public static string ls_please;
        public static string ls_check;
        public static string ls_clear;
        public static string ls_status;
        public static string ls_owner;
        public static string ls_setting;
        public static string ls_test;
        public static string ls_test_setting;
        public static string ls_output;
        public static string ls_input;
        public static string ls_message;
        public static string ls_if_or_not;
        public static string ls_success;
        public static string ls_no;
        public static string ls_content;
        public static string ls_prompt;
        public static string ls_text;
        public static string ls_time;
        public static string ls_log;
        public static string ls_open;
		public static string ls_database;
		//Language
		public static string ls_english;
        public static string ls_chinese;
        //Menu Bar string
        public static string ls_file;
        public static string ls_option;
        public static string ls_view;
        public static string ls_step;
        public static string ls_start;
        public static string ls_stop;
        public static string ls_help;
        public static string ls_language;
        public static string ls_import;
        public static string ls_import_fail;
        public static string ls_import_sucess;
        public static string ls_export;
        public static string ls_export_fail;
        public static string ls_export_sucess;
        public static string ls_exit;
        public static string ls_order;
        public static string ls_rescan_serial_port;
        public static string ls_connect;
        public static string ls_stable;
        public static string ls_disconnect;
        public static string ls_has_stop;
        public static string ls_modify;
        public static string ls_auto_test;
        public static string ls_fail_log;
        public static string ls_fail_export;
        public static string ls_product;
        //StripButton
        public static string ls_scan;
        public static string ls_open_com;
        public static string ls_close_com;
        //From
        public static string ls_bluetooth_test;
        public static string ls_verion_h;//help
        //serial
        public static string ls_com_port;
        public static string ls_baud_rate;
        public static string ls_data_bits;
        public static string ls_parity;
        public static string ls_stop_bits;
        public static string ls_product_line;
        public static string ls_p_line;
        public static string ls_order_no;
        public static string ls_worker_no;
        public static string ls_server_name;
        public static string ls_device_type;
        public static string ls_mac_select;
        //Ctest
        public static string ls_not_test;
        public static string ls_pass;
        public static string ls_fail;
        public static string ls_result;
        public static string ls_warning;
        //Other
        public static string ls_error_no_serial_port;
        public static string ls_error_no_serial_start;
        public static string ls_com_is_open;
        //datagridview
        public static string ls_select;
        public static string ls_id;
        public static string ls_number;
        public static string ls_item;
        public static string ls_min;
        public static string ls_max;
        public static string ls_mask;
        public static string ls_must;
        public static string ls_value;
        public static string ls_datagridview_status;
        public static string ls_remark;

        //test item
        public static string ls_name;
        public static string ls_p_name;
        public static string ls_version;
        public static string ls_mac;
        public static string ls_rssi;
        public static string ls_voltage;
        public static string ls_resistance;
        public static string ls_resistor;
        public static string ls_weight;
        public static string ls_total;
        public static string ls_pass_count;
        public static string ls_fail_count;
        public static string ls_waring_count;
        public static string ls_nottest_count;
        //export list
        public static string ls_exportlist;
        public static string ls_importlist;
        public static string ls_save_setting;
        public static string ls_load_setting;
        public static string ls_test_list;
        public static string ls_new;
        public static string ls_signal;
        public static string ls_worker;
        public static string ls_operator;
        public static string ls_wait_stable;
        public static string ls_disconn_time;
        //order
        public static string ls_entry_order;
        public static string ls_inquiry_order;
        public static string ls_order_status;
        public static string ls_product_name;
        public static string ls_quantity;
        public static string ls_unit_price;
        public static string ls_total_amount;
        public static string ls_order_owner;
        public static string ls_start_time;
        public static string ls_delivery_time;
        //
        public static string ls_feike;
        public static string ls_complete;
        public static string ls_inquiry;
        public static string ls_condition;
        public static string ls_increase;
        public static string ls_entry_worker;
        public static string ls_inquiry_worker;
        public static string ls_delete_worker;
        public static string ls_delete_id;
        public static string ls_employee;
        public static string ls_login;
        public static string ls_register;
        public static string ls_user_name;
        public static string ls_password;
        public static string ls_check_ditto;
        public static string ls_q_check_ditto;
        public static string ls_q_ditto_test;
        public static string ls_q_restart_again;
        public static string ls_ble_chip;
        public static string ls_auto_acq;
        public static string ls_i_db_not_conn;//i:informaotion
        public static string ls_db_conn_success;
        public static string ls_db_conn_fail;
        //customer
        public static string ls_customer;
        public static string ls_customer_name;
        public static string ls_customer_type;
        public static string ls_websit;
        public static string ls_pioneer;
        public static string ls_country;
        public static string ls_country_area;
        public static string ls_introduction;
        public static string ls_trade_product;
        public static string ls_coordinate;
        public static string ls_work_group_name;
        public static string ls_mail;
        public static string ls_contact;
        public static string ls_credit_points;
        public static string ls_end_time;
        public static string ls_file_path;
        public static string ls_address;
        public static string ls_level;
        public static string ls_enter_customer;
        public static string ls_inquiry_customer;
        public static string ls_debug;
        public static string ls_debug_mode;
        public static string ls_del_db;
        //product_line
        public static string ls_product_line_number;
        public static string ls_product_line_name;
        public static string ls_product_line_who;
        public static string ls_product_line_level;
        public static string ls_product_line_what;
        public static string ls_product_line_where;
        public static string ls_product_line_status;
        public static string ls_product_line_capacity;
        public static string ls_product_line_contact;
        public static string ls_product_line_create;
        public static string ls_product_line_start;
        public static string ls_product_line_end;
        public static string ls_product_line_entry;
        public static string ls_product_line_inquire;
        public static string ls_product_line_delete;
        public static string ls_product_line_modify;
        public static string ls_insert_product_line;
        public static string ls_product_capacity;
        public static string ls_automatic_acquisition;
        //fun
        public Clanguage(LanguageSel sel= LanguageSel.English)
        {
            Clanguage.sel_language(sel);
            Clanguage.lang = sel;
        }

        public static void sel_language(LanguageSel sel = LanguageSel.English)
        {
            Clanguage.ls_english = "English";
            Clanguage.ls_chinese = "��������";
            Clanguage.ls_colon = ":";
            if (sel == LanguageSel.English) Clanguage.sel_english();
            if (sel == LanguageSel.Chinese) Clanguage.sel_chinese();
            Clanguage.lang = sel;
        }

        public static void sel_english()
        {
            if (Clanguage.lang == LanguageSel.English) return;
			Clanguage.ls_stock = "Stock";
			Clanguage.ls_group = "Group";
			Clanguage.ls_edit = "Edit";
			Clanguage.ls_organization = "Organization";
			Clanguage.ls_record = "Record";
			Clanguage.ls_workspace = "Workspace";
			Clanguage.ls_company = "Company";
			Clanguage.ls_personnel = "Personnel";
			Clanguage.ls_fiscal = "Fiscal";
			Clanguage.ls_materials = "Materials";
			Clanguage.ls_project = "Project";
			Clanguage.ls_develop = "Develop";
			Clanguage.ls_business = "Business";
			Clanguage.ls_legal_affairs = "LegalAffairs";
			Clanguage.ls_environment_safety = "environment";
			Clanguage.ls_require = "Require";
			Clanguage.ls_training = "Training";
			Clanguage.ls_communicate = "Communicate";
			Clanguage.ls_service = "Service";
			Clanguage.ls_task = "Task";
			Clanguage.ls_question = "Question";
			Clanguage.ls_error = "Error";
            Clanguage.ls_please = "Please";
            Clanguage.ls_check = "Check";
            Clanguage.ls_clear = "Clear";
            Clanguage.ls_status = "Status";
            Clanguage.ls_owner = "Owner";
            Clanguage.ls_file = "File";
            Clanguage.ls_option = "Option";
            Clanguage.ls_view = "View";
            Clanguage.ls_step="Step";
            Clanguage.ls_start="Start";
            Clanguage.ls_stop="Stop";
            Clanguage.ls_help="Help";
            Clanguage.ls_language="Language";
            Clanguage.ls_if_or_not = "If or Not ";
            Clanguage.ls_success = "Success";
            Clanguage.ls_no = "No";
            Clanguage.ls_text = "Text";
            Clanguage.ls_log = "Log";
            Clanguage.ls_open = "Open";
			Clanguage.ls_database = "DataBase";
            Clanguage.ls_content = "Content";
            Clanguage.ls_prompt = "Prompt";
            Clanguage.ls_import="Import";
            Clanguage.ls_import_fail = "Import Fail ";
            Clanguage.ls_import_sucess = "Import Success ";
            Clanguage.ls_export="Export";
            Clanguage.ls_export_fail="Export Fail ";
            Clanguage.ls_export_sucess= "Export Success ";
            Clanguage.ls_exit="Exit";
            Clanguage.ls_order="Order";
            Clanguage.ls_rescan_serial_port="RescanSerialPort";
            Clanguage.ls_connect="Connect";
            Clanguage.ls_disconnect="Disconnect";
            Clanguage.ls_bluetooth_test = "BluetoothTest";
            Clanguage.ls_verion_h = "Version";
            Clanguage.ls_serial_port = "SerialPort";
            Clanguage.ls_fail_log = "FailLog";
            Clanguage.ls_product = "Product";
            Clanguage.ls_scan = "Scan";
            Clanguage.ls_stable = "Stable";
            Clanguage.ls_open_com = "Open COM";
            Clanguage.ls_close_com = "Close COM";
            Clanguage.ls_setting = "Setting";
            Clanguage.ls_test = "Test";
            Clanguage.ls_time = "Time";
            Clanguage.ls_modify = "Modify";
            Clanguage.ls_auto_test = "AutoTest";
            Clanguage.ls_test_setting = "TestSetting";
            Clanguage.ls_output = "Output";
            Clanguage.ls_input = "Input";
            Clanguage.ls_com_port="ComPort";
            Clanguage.ls_baud_rate="BaudRate";
            Clanguage.ls_data_bits="DataBits";
            Clanguage.ls_parity="Parity";
            Clanguage.ls_stop_bits="StopBits";
            Clanguage.ls_product_line="ProductLine";
            Clanguage.ls_p_line = "Line";
            Clanguage.ls_order_no = "OrderNO.";
            Clanguage.ls_worker_no = "WorkerNO.";
            Clanguage.ls_server_name = "ServerName";
            Clanguage.ls_device_type = "DeviceType";
            Clanguage.ls_mac_select = "MAC Select";
            Clanguage.ls_error_no_serial_port = "Error:No serial port found!";
            Clanguage.ls_error_no_serial_start="Error:No serial port start!";
            Clanguage.ls_com_is_open = "COM is opening";
            Clanguage.ls_not_test = "Result:[NotTest]";
            Clanguage.ls_fail = "Result:[Fail]";
            Clanguage.ls_pass = "Result:[Pass]";
            Clanguage.ls_fail_export = "Fail";
            Clanguage.ls_result = "Result";
            Clanguage.ls_warning = "Warning";
            Clanguage.ls_has_stop = "Has stopped";
            Clanguage.ls_message = "Message";
            Clanguage.ls_select="select";
            Clanguage.ls_id="id";
            Clanguage.ls_number = "Number";
            Clanguage.ls_item="item";
            Clanguage.ls_min="min";
            Clanguage.ls_max="max";
            Clanguage.ls_mask="mask";
            Clanguage.ls_must = "must";
            Clanguage.ls_value="value";
            Clanguage.ls_datagridview_status="status";
            //test item
            Clanguage.ls_name= "Name";
            Clanguage.ls_p_name = "Name"; //iditem 1
            Clanguage.ls_version= "Version";
            Clanguage.ls_mac= "MAC";
            Clanguage.ls_rssi= "RSSI";
            Clanguage.ls_voltage= "Voltage";
            Clanguage.ls_resistance= "Resistance";
            Clanguage.ls_resistor = "Resistor";
            Clanguage.ls_weight= "Weight";
            Clanguage.ls_total = "Total";
            Clanguage.ls_pass_count="PassCount";
            Clanguage.ls_fail_count="FailCount";
            Clanguage.ls_waring_count="WarningCount";
            Clanguage.ls_nottest_count="NotTestCount";
            //export list
            Clanguage.ls_exportlist = "ExportList";
            Clanguage.ls_importlist = "InportList";
            Clanguage.ls_save_setting = "SaveSetting";
            Clanguage.ls_load_setting = "LoadSetting";
            Clanguage.ls_test_list = "TestingList";
            Clanguage.ls_new = "New";
            Clanguage.ls_signal = "Signal";
            Clanguage.ls_worker = "Worker";
            Clanguage.ls_operator = "Operator";
            Clanguage.ls_wait_stable = "WaitStable";
            Clanguage.ls_disconn_time = "DisconnTime";
            Clanguage.ls_entry_order = "EntryOrder";
            Clanguage.ls_inquiry_order = "InquiryOrder";
            Clanguage.ls_order_status = "OrderStatus";
            Clanguage.ls_product_name = "ProductName";
            Clanguage.ls_quantity = "Quantity";
            Clanguage.ls_unit_price = "UnitPrice";
            Clanguage.ls_total_amount = "TotalAmount";
            Clanguage.ls_order_owner = "OrderOwner";
            Clanguage.ls_start_time = "StartTime";
            Clanguage.ls_delivery_time = "DeliveryTime";
            Clanguage.ls_feike = "FLYCO";
            Clanguage.ls_complete = "Complete";
            Clanguage.ls_inquiry = "Inquiry";
            Clanguage.ls_condition = "Condition";
            Clanguage.ls_increase = "Increase";
            Clanguage.ls_entry_worker = "EntryWorker";
            Clanguage.ls_inquiry_worker = "InquiryWorker";
            Clanguage.ls_delete_worker = "DeleteWorker";
            Clanguage.ls_delete_id = "DeleteID";
            Clanguage.ls_employee = "Employee";
            Clanguage.ls_login = "Login";
            Clanguage.ls_register = "Register";
            Clanguage.ls_user_name = "UserName";
            Clanguage.ls_password = "Password";
            Clanguage.ls_remark = "Remark";
            Clanguage.ls_check_ditto = "CheckDitto";
            Clanguage.ls_q_check_ditto = "Do the same for two consecutive addresses, please confirm whether the test?";
            Clanguage.ls_q_ditto_test = "Repeat the same for two consecutive addresses, please confirm whether to repeat the test?";
            Clanguage.ls_q_restart_again = "Replace the serial port Please start again.";
            Clanguage.ls_ble_chip = "BLE Chip";
            Clanguage.ls_auto_acq = "Auto-Acquisition";
            Clanguage.ls_i_db_not_conn = "The database is not connected.";
            Clanguage.ls_db_conn_success = "The database connection is successful.";
            Clanguage.ls_db_conn_fail = "Database connection failed.";
            Clanguage.ls_customer = "Customer";
            Clanguage.ls_customer_name = "CustomerName";
            Clanguage.ls_customer_type = "CustomerType";
            Clanguage.ls_websit = "Website";
            Clanguage.ls_pioneer = "Pioneer";
            Clanguage.ls_country = "Country";
            Clanguage.ls_country_area = "CountryArea";
            Clanguage.ls_trade_product = "TradeProduct";
            Clanguage.ls_introduction = "Introduction";
            Clanguage.ls_work_group_name = "WorkingGroup";
            Clanguage.ls_mail = "e-mail";
            Clanguage.ls_contact = "Contact";
            Clanguage.ls_coordinate = "Coordinate";
            Clanguage.ls_credit_points = "CreditPoints";
            Clanguage.ls_end_time = "EndTime";
            Clanguage.ls_file_path = "FilePath";
            Clanguage.ls_address = "Address";
            Clanguage.ls_level = "Level";
            Clanguage.ls_enter_customer = "EnterCustomer";
            Clanguage.ls_inquiry_customer = "InquiryCustomer";
            Clanguage.ls_debug = "Debug";
            Clanguage.ls_debug_mode = "DebugMode";
            Clanguage.ls_del_db = "DeleteDatabase";
            //product line
            Clanguage.ls_product_line_number= "ProductLineNumber";
            Clanguage.ls_product_line_name = "ProductLineName";
            Clanguage.ls_product_line_who = "ProductLineWho";
            Clanguage.ls_product_line_level = "ProductLineLevel";
            Clanguage.ls_product_line_what = "ProductLineWhat";
            Clanguage.ls_product_line_where = "ProductLineWhere";
            Clanguage.ls_product_line_status = "ProductLineStatus";
            Clanguage.ls_product_line_capacity = "ProductLineCapacity";
            Clanguage.ls_product_line_contact = "ProductLineContact";
            Clanguage.ls_product_line_create = "ProductLineCreate";
            Clanguage.ls_product_line_start = "ProductLineStart";
            Clanguage.ls_product_line_end = "ProductLineEnd";
            Clanguage.ls_product_line_entry = "ProductLineEntry";
            Clanguage.ls_product_line_inquire = "ProductLineInquiry";
            Clanguage.ls_product_line_delete = "ProductLineDelete";
            Clanguage.ls_product_line_modify = "ProductLineModify";
            Clanguage.ls_insert_product_line = "Insert Product Line ";
            Clanguage.ls_product_capacity = "ProductCapacity";
            Clanguage.ls_automatic_acquisition = "Automatic acquisition";
        }

        public static void sel_chinese()
        {
            if (Clanguage.lang == LanguageSel.Chinese) return;
			Clanguage.ls_stock = "�ɷ�";
			Clanguage.ls_group = "����";
			Clanguage.ls_edit = "�༭";
			Clanguage.ls_organization = "��֯�ܹ�";
			Clanguage.ls_record = "��¼";
			Clanguage.ls_workspace = "������";
			Clanguage.ls_company = "��˾";
			Clanguage.ls_personnel = "����";
			Clanguage.ls_fiscal = "����";
			Clanguage.ls_materials = "����";
			Clanguage.ls_develop = "�з�";
			Clanguage.ls_project = "��Ŀ";
			Clanguage.ls_business = "����";
			Clanguage.ls_legal_affairs = "����";
			Clanguage.ls_environment_safety = "����";
			Clanguage.ls_require = "����";
			Clanguage.ls_training = "��ѵ";
			Clanguage.ls_communicate = "ͨ��";
			Clanguage.ls_service = "����";
			Clanguage.ls_task = "����";
			Clanguage.ls_question = "����";
			Clanguage.ls_error = "����";
            Clanguage.ls_please = "��";
            Clanguage.ls_check = "���";
            Clanguage.ls_clear = "���";
            Clanguage.ls_status = "״̬";
            Clanguage.ls_owner = "������";
            Clanguage.ls_file = "�ļ�";
            Clanguage.ls_option = "ѡ��";
            Clanguage.ls_view = "��ͼ";
            Clanguage.ls_step = "����";
            Clanguage.ls_start = "��ʼ";
            Clanguage.ls_stop = "ֹͣ";
            Clanguage.ls_help = "����";
            Clanguage.ls_language = "����";
            Clanguage.ls_if_or_not = "�Ƿ� ";
            Clanguage.ls_success = "�ɹ�";
            Clanguage.ls_no = "û��";
            Clanguage.ls_text = "�ı�";
            Clanguage.ls_log = "��¼";
            Clanguage.ls_open = "������";
			Clanguage.ls_database = "���ݿ�";
			Clanguage.ls_content = "����";
            Clanguage.ls_prompt = "��ʾ";
            Clanguage.ls_import="����";
            Clanguage.ls_import_fail = "����ʧ�� ";
            Clanguage.ls_import_sucess = "����ɹ� ";
            Clanguage.ls_export="����";
            Clanguage.ls_export_fail = "����ʧ�� ";
            Clanguage.ls_export_sucess = "�����ɹ� ";
            Clanguage.ls_exit="�˳�";
            Clanguage.ls_order="����";
            Clanguage.ls_rescan_serial_port="����ɨ�贮��";
            Clanguage.ls_connect="����";
            Clanguage.ls_disconnect="�Ͽ�";
            Clanguage.ls_bluetooth_test = "��������";
            Clanguage.ls_verion_h = "�汾";
            Clanguage.ls_serial_port = "����";
            Clanguage.ls_scan = "ɨ��";
            Clanguage.ls_stable = "�ȶ�";
            Clanguage.ls_open_com = "�򿪴���";
            Clanguage.ls_close_com = "�رմ���";
            Clanguage.ls_fail_log = "�����¼";
            Clanguage.ls_product = "��Ʒ";
            Clanguage.ls_setting = "����";
            Clanguage.ls_test = "����";
            Clanguage.ls_time = "ʱ��";
            Clanguage.ls_modify = "�޸�";
            Clanguage.ls_auto_test = "�Զ�����";
            Clanguage.ls_test_setting = "��������";
            Clanguage.ls_output = "���";
            Clanguage.ls_input = "����";
            Clanguage.ls_com_port="���ں�";
            Clanguage.ls_baud_rate="������";
            Clanguage.ls_data_bits="����λ";
            Clanguage.ls_parity = "��żУ��";
            Clanguage.ls_stop_bits = "ֹͣλ";
            Clanguage.ls_product_line = "����";
            Clanguage.ls_p_line = "����";
            Clanguage.ls_order_no = "������";
            Clanguage.ls_worker_no = "����";
            Clanguage.ls_server_name = "������";
            Clanguage.ls_device_type = "�豸����";
            Clanguage.ls_mac_select = "MACѡ��";
            Clanguage.ls_error_no_serial_port = "����:δ�ҵ�����!";
            Clanguage.ls_error_no_serial_start="����:û�д��ڱ�����!";
            Clanguage.ls_com_is_open = "�����ѿ���";
            Clanguage.ls_not_test = "���:[δ����]";
            Clanguage.ls_fail = "���:[ʧ��]";
            Clanguage.ls_fail_export = "ʧ����";
            Clanguage.ls_pass = "���:[ͨ��]";
            Clanguage.ls_result = "���";
            Clanguage.ls_warning = "����";
            Clanguage.ls_has_stop = "�Ѿ�ֹͣ";
            Clanguage.ls_message = "��Ϣ";
            Clanguage.ls_select = "ѡ��";
            Clanguage.ls_id = "���";
            Clanguage.ls_number = "���";
            Clanguage.ls_item = "����";
            Clanguage.ls_min = "��Сֵ";
            Clanguage.ls_max = "���ֵ";
            Clanguage.ls_mask = "��ֵ";
            Clanguage.ls_must = "��ֵ";
            Clanguage.ls_value = "����ֵ";
            Clanguage.ls_datagridview_status = "״̬";
            //test item
            Clanguage.ls_name = "����"; //iditem 1
            Clanguage.ls_p_name = "����"; //iditem 1
            Clanguage.ls_version = "�汾��";//iditem 2
            Clanguage.ls_mac = "MAC";//iditem 3
            Clanguage.ls_rssi = "�ź�ǿ��";//iditem 4
            Clanguage.ls_voltage = "��ѹ";//iditem 5
            Clanguage.ls_resistance = "����";//iditem 6
            Clanguage.ls_resistor = "����";
            Clanguage.ls_weight = "����";//iditem 7
            Clanguage.ls_total = "�ϼ�";
            Clanguage.ls_pass_count = "ͨ��";
            Clanguage.ls_fail_count = "ʧ��";
            Clanguage.ls_waring_count = "����";
            Clanguage.ls_nottest_count = "δ����";
            //export list
            Clanguage.ls_exportlist = "�����嵥";
            Clanguage.ls_importlist = "�����嵥";
            Clanguage.ls_save_setting = "��������";
            Clanguage.ls_load_setting = "��������";
            Clanguage.ls_test_list = "�����б�";
            Clanguage.ls_new = "�½�";
            Clanguage.ls_signal = "�ź�";
            Clanguage.ls_worker = "����";
            Clanguage.ls_operator = "����Ա";
            Clanguage.ls_wait_stable = "�ȴ��ȶ�";
            Clanguage.ls_disconn_time = "�Ͽ�ʱ��";
            Clanguage.ls_entry_order = "¼�붩��";
            Clanguage.ls_inquiry_order = "��ѯ����";
            Clanguage.ls_order_status = "����״̬";
            Clanguage.ls_product_name = "��Ʒ����";
            Clanguage.ls_quantity = "����";
            Clanguage.ls_unit_price = "����";
            Clanguage.ls_total_amount = "�ܽ��";
            Clanguage.ls_order_owner = "����Ա";
            Clanguage.ls_start_time = "ǩ��ʱ��";
            Clanguage.ls_delivery_time = "����ʱ��";
            Clanguage.ls_feike = "�ɿ�";
            Clanguage.ls_complete = "���";
            Clanguage.ls_inquiry = "��ѯ";
            Clanguage.ls_condition = "����";
            Clanguage.ls_increase = "����";
            Clanguage.ls_entry_worker = "¼��Ա��";
            Clanguage.ls_inquiry_worker = "��ѯԱ��";
            Clanguage.ls_delete_worker="ɾ��Ա��";
            Clanguage.ls_delete_id="ɾ�����";
            Clanguage.ls_employee = "Ա��";
            Clanguage.ls_login = "��½";
            Clanguage.ls_register = "ע��";
            Clanguage.ls_user_name = "�û���";
            Clanguage.ls_password = "����";
            Clanguage.ls_remark = "��ע";
            Clanguage.ls_check_ditto = "�ظ���ַȷ��";
            Clanguage.ls_q_ditto_test ="�������ε�ַ��ͬ����ȷ���Ƿ����ظ����� ?";
            Clanguage.ls_q_restart_again = "�������������¿�ʼ.";
            Clanguage.ls_ble_chip = "BLE оƬ";
            Clanguage.ls_auto_acq = "�Զ���ȡ";
            Clanguage.ls_i_db_not_conn = "���ݿ�δ����";
            Clanguage.ls_db_conn_success = "���ݿ����ӳɹ�";
            Clanguage.ls_db_conn_fail = "���ݿ�����ʧ��";
            Clanguage.ls_customer = "�ͻ�";
            Clanguage.ls_customer_name = "�ͻ���";
            Clanguage.ls_customer_type = "�ͻ�����";
            Clanguage.ls_websit = "��ַ";
            Clanguage.ls_pioneer = "������";
            Clanguage.ls_country = "����";
            Clanguage.ls_country_area = "����";
            Clanguage.ls_trade_product = "����Ʒ";
            Clanguage.ls_introduction = "���";
            Clanguage.ls_work_group_name = "Ⱥ����";
            Clanguage.ls_mail = "e-mail";
            Clanguage.ls_contact = "��ϵ��";
            Clanguage.ls_coordinate = "����";
            Clanguage.ls_credit_points = "���÷�";
            Clanguage.ls_end_time = "���ʱ��";
            Clanguage.ls_file_path = "����·��";
            Clanguage.ls_address = "��ַ";
            Clanguage.ls_level = "�ȼ�";
            Clanguage.ls_enter_customer = "¼��ͻ�";
            Clanguage.ls_inquiry_customer = "��ѯ�ͻ�";
            Clanguage.ls_debug = "����";
            Clanguage.ls_debug_mode = "����ģʽ";
            Clanguage.ls_del_db = "ɾ�����ݿ�";
            //product line
            Clanguage.ls_product_line_number = "���ߺ�";
            Clanguage.ls_product_line_name = "������";
            Clanguage.ls_product_line_who = "����������";
            Clanguage.ls_product_line_level = "���߼���";
            Clanguage.ls_product_line_what = "���߲�Ʒ";
            Clanguage.ls_product_line_where = "���ߵص�";
            Clanguage.ls_product_line_status = "����״̬";
            Clanguage.ls_product_line_capacity = "���߲���";
            Clanguage.ls_product_line_contact = "��ϵ��ʽ";
            Clanguage.ls_product_line_create = "���ߴ���ʱ��";
            Clanguage.ls_product_line_start = "����Ͷ��ʱ��";
            Clanguage.ls_product_line_end = "����ͣ��ʱ��";
            Clanguage.ls_product_line_entry = "¼�����";
            Clanguage.ls_product_line_inquire = "��ѯ����";
            Clanguage.ls_product_line_delete = "ɾ������";
            Clanguage.ls_product_line_modify = "�޸Ĳ���";
            Clanguage.ls_insert_product_line = "�������";
            Clanguage.ls_product_capacity = "����";
            Clanguage.ls_automatic_acquisition = "�Զ���ȡ";
        }


}//end  Clanguage
    
}//end n_language