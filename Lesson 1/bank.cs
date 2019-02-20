using System;

namespace Accounts{

    class Account{
        decimal money = 0;
        string name;
        string pass = "111111";
        int id;
        static int accountCnt = 0;

        public int ID{
            get{
                return id;
            }
            private set{
                id = value;
            }
        }

        public decimal GetMoney{
            get{
                return money;
            }
            private set{
                if(value < 0){
                    Console.WriteLine("Not enough money");
                }else{
                    money = value;
                }
            }
        }

        public string Password{
            private get{
                return pass;
            }
            set{
                if(value.Length < 5){
                    Console.WriteLine("Too short password. You password was set to 111111");
                }else{
                    pass = value;
                }
            }
        }

        public static int GetNumberOfAccounts{
            get{
                return accountCnt;
            }
        }

        public Account(string _name, string _pass, decimal _money){
            name = _name;
            Password = _pass;
            GetMoney = _money;
            ID = ++accountCnt;
        }

        public static void ShowAccount(Account acc){
            Console.WriteLine("Name of owner: {0} Account ID: {1}, Money: {2}\n", acc.name, acc.ID, acc.GetMoney);
        }

        public void Transaction(decimal _money, bool add){
            if(add){
                Console.WriteLine("Adding {0} to the account", _money);
                GetMoney += _money;
                Console.WriteLine(_money + " were added to the account");
                ShowAccount(this);
            }else{
                Console.WriteLine("Subtructing {0} from the account", _money);
                GetMoney -= _money;
                ShowAccount(this);
            }
        }
    }

    class Execute{
        public static void Main(){
            Account acc1 = new Account("Kirill Solovyov", "112233", 1000);
            acc1.Transaction(200, true);
            acc1.Transaction(2000, false);
            Account acc2 = new Account("Berik", "Berik", 100);
            Account.ShowAccount(acc2);
            Console.WriteLine("Total user of the bank: {0}", Account.GetNumberOfAccounts);
        }
    }
}