#include<iostream>
#include <vector>
#include<string.h>
using namespace std;
int  sizeCounter(0);
int del(0);
int detailsAccount(vector<string> &firstName ,vector<string> &lastName, vector<int> &account_number,vector<int> &balance);
void deleteAccount(vector<string> &firstName ,vector<string> &lastName, vector<int> &account_number,vector<int> &balance);
void displayAccount(vector<string> &firstName ,vector<string> &lastName, vector<int> &account_number,vector<int> &balance);
void depositAccount(vector<int> &account_number,vector<int> &balance);
void withdrawalAccount(vector<int> &account_number,vector<int> &balance);
void sortAccounts(vector<string> &firstName ,vector<string> &lastName,vector<int> &balance, vector<int> &account_number);
void  averageBalance(vector<int> &balance);
void  totalBalance(vector<int> &balance);
int compare(string s1,string s2);
bool isDigit(char check);
int main ()
{
    int option(0);
    vector <string>firstName (100);
    vector <string>lastName (100);
    vector <int>account_number (100,0);
    vector <int>balance(100,0);
    while(1)
    {
            cout<<"--------------------------------------------------------------------------------------------------------------------"<<endl; 
            cout<<"\t\t\t\t\t\t\tMENU"<<endl;
            cout<<"--------------------------------------------------------------------------------------------------------------------"<<endl;     
            cout<<"1. Add a bank account."<<endl;
            cout<<"2. Remove a bank account."<<endl; 
            cout<<"3. Display the information of a particular client by account number"<<endl;
            cout<<"4. Apply a deposit to a particular account. (by account number)"<<endl;
            cout<<"5. Apply a withdrawal from a particular account. (by account number)"<<endl;
            cout<<"6. Sort and display the list of clients according to their balance, family name and given name, in ascending order"<<endl;
            cout<<"7. Display the average balance value of the account_number."<<endl;
            cout<<"8. Display the total balance value of the account_number."<<endl;
            cout<<"9. Exit the application."<<endl;
            cout<<endl;
            cout<<"--------------------------------------------------------------------------------------------------------------------"<<endl;    
            cout<<"Enter desired option"<<endl;
            cin>>option;
            while (cin.fail() || cin.peek() != '\n')
                    {
                        cin.clear();
                        cin.ignore(512, '\n');
                        cout << "Warning , Enter integer only !: ";
                        cin >>option;
                    }
            if(option==1)
            {  
                detailsAccount(firstName,lastName,account_number,balance);
            }
        
            else  if(option==2)
            {
                 deleteAccount(firstName,lastName,account_number,balance);
                
            }
           else if(option==3)
            {
                displayAccount(firstName,lastName,account_number,balance);
            }
          else  if(option==4)
            {
                depositAccount(account_number,balance);
            }
            else  if(option==5)
            {
                withdrawalAccount(account_number,balance);
            }
            else  if(option==6)
            {
                sortAccounts(firstName,lastName,balance,account_number);
            }
            else  if(option==7)
            {
                    averageBalance(balance);
            }
            else  if(option==8)
            {
                    totalBalance(balance);
            }
            else if(option==9)
                exit(0);
            else 
                cout<<"Invalid input"<<endl;
    }    
cout<<"-------------------------------------------------------------------------------------"<<endl;    
}
    
int detailsAccount(vector<string> &firstName ,vector<string> &lastName, vector<int> &account_number,vector<int> &balance)
{
        for( int i=sizeCounter;i<=sizeCounter;i++)
            {
                cout<<"-------------------------------------------------------------------------------------"<<endl;
                if(account_number[i]==0)
                {
                    cout<<"Enter First name "<<endl;
                    cin>>firstName.at(i);
                    cin.ignore(256, '\n');
                    int flag=0,symbol=0;
                    string check{""};
                    do
                    {
                        check=firstName[i];
                        symbol=0;
                        for(int j=0;check[j]!='\0';j++)     //validation of  input of First name values
                        {
                            if(isDigit(check[j])==true)
                            {
                                flag=1;
                                break;
                            }
                            else if(check[j]=='.' || check[j]=='@' || check[j]=='_')
                            {
                                symbol=1;
                            }
                            else
                                flag=0;
                        }
                if(flag==1 || symbol==1)       //if there is a integer or symbol its gonna take input again
                {
                    cout<<"Warning.....character values only.."<<endl;
                    cout<<"First name "<<endl;
                    cin>>firstName[i];
                    cin.ignore(256, '\n');
                }
            }while(flag==1 || symbol==1);
            
                cout<<"Last name "<<endl  ;
                cin>>lastName.at(i);
                cin.ignore(256, '\n');

            flag=0,symbol=0;
            check="";
            do
            {
                check=lastName[i];
                symbol=0;
                               
                for(int j=0;check[j]!='\0';j++)     //Validations for Input on Family name
                {
                    if(isDigit(check[j])==true)
                    {
                          flag=1;
                          break;
                    }
                   else if(check[j]=='.' || check[j]=='@' || check[j]=='_')
                        symbol=1;
                    else
                        flag=0;
                        
                }
                if(flag==1 || symbol==1)       //if there is a integer or symbol its gonna take input again
                {
                    cout<<"Warning.....character values only.."<<endl;
                    cout<<"Last name"<<endl;
                    cin>>lastName[i];
                    
                    cin.ignore(256, '\n');
                }
            }while(flag==1 || symbol==1); 
            
                cout<<"Enter Account Number "<<endl;
account:  cin>>account_number.at(i);
                while (cin.fail() || cin.peek() != '\n')
                    {
                        cin.clear();
                        cin.ignore(512, '\n');
                        cout << "Warning , Enter integers !: ";
                        cin >>account_number.at(i);
                    }
                if(account_number.at(i)<=10000 || account_number.at(i)>10100 )
                { 
                    cout<<"Enter Account number between 10000 &10099"<<endl;
                    goto account;
                }
                cout<<"Enter Balance "<<endl;
one:         cin>>balance.at(i);
                while (cin.fail() || cin.peek() != '\n')
                    {
                        cin.clear();
                        cin.ignore(512, '\n');
                        cout << "Warning , Enter integers !: ";
                        balance.at(i);
                    }
            if(balance[i]<0){
                cout<<"Enter positive values only "<<endl;
                cout<<"Enter Balance"<<endl; 
                goto one;
            }
            cout<<"-------------------------------------------------------------------------------------"<<endl;
    sizeCounter++;
            return sizeCounter; }
}
}

void displayAccount(vector<string> &firstName ,vector<string> &lastName, vector<int> &account_number,vector<int> &balance)
{   
            int account_search(0);
            cout<<"Enter Account number to display its customer details"<<endl;
            cin>>account_search;
            
            for(int i=0;i<sizeCounter;i++)
            {
                if(account_number.at(i)==account_search)
                    {
                        cout<<"-------------------------------------------------------------------------------------"<<endl;
                        cout<<"Details of Customer for account "<<account_number.at(i)<<"  are"<<endl;
                        cout<<"FirstName\tLastName\tAccountNumber\t Balance"<<endl;
                        cout<<firstName.at(i)<<" \t "<<lastName.at(i)<<" \t "<<account_number.at(i)<<"\t"<<balance.at(i)<<endl;
                        cout<<"-------------------------------------------------------------------------------------"<<endl;
                    }
                    else
                    {
                        cout<<"Invalid Account number!!!!"<<endl;
                    }
            }
}
void depositAccount(vector<int> &account_number,vector<int> &balance)
{
     int account_search(0),deposit_amount(0);
            cout<<"Enter Account number to which amount to be deposited "<<endl;
            cin>>account_search;
            for(int i=0;i<sizeCounter;i++)
            {
                if(account_number.at(i)==account_search)
                    {
                        cout<<"-------------------------------------------------------------------------------------"<<endl;
                        cout<<"Current Balance of  Account "<<account_number.at(i) <<" is "<<balance.at(i)<<endl;
                        cout<<"Enter amount to be deposited  "<<endl;
                        cin>>deposit_amount;
                        while (cin.fail() || cin.peek() != '\n')
                        {
                            cin.clear();
                            cin.ignore(512, '\n');
                            cout << "Warning , Enter integers !: ";
                            cin >>deposit_amount;
                        }
                        cout<<deposit_amount<<" $ has been deposited to account  "<<account_number.at(i) <<endl;
                        balance.at(i)+=deposit_amount;
                        cout<<"New balance : "<<balance.at(i)<<"$"<<endl;
                        cout<<"-------------------------------------------------------------------------------------"<<endl;
                    }
                    else
                    {
                        cout<<"Invalid Account number "<<endl;
                    }
            }
}

void withdrawalAccount(vector<int> &account_number,vector<int> &balance)
{
     int account_search(0),withdrawalAmount(0);
     cout<<"-------------------------------------------------------------------------------------"<<endl;
            cout<<"Enter Account number to which amount to be withdrawn "<<endl;
            cin>>account_search;
                    while (cin.fail() || cin.peek() != '\n')
                    {
                        cin.clear();
                        cin.ignore(512, '\n');
                        cout << "Warning , Enter Integers !: ";
                        cin >>account_search;
                    }
            for(int i=0;i<sizeCounter;i++)
            {
                if(account_number.at(i)==account_search)
                    {
                        cout<<"Current Balance of  Account "<<account_number.at(i) <<" is "<<balance.at(i)<<endl;
two:                 cout<<"Enter amount to be withdrawal  "<<endl;
                        cin>>withdrawalAmount;
                        while (cin.fail() || cin.peek() != '\n')
                        {
                            cin.clear();
                            cin.ignore(512, '\n');
                            cout << "Warning , Enter digits !: ";
                            cin >>withdrawalAmount;
                        }
                    
                        if(balance.at(i)==0)
                        {
                                cout<<"LOW BALANCE"<<endl;
                        } 
                        else 
                        {
                             if(balance[i]<withdrawalAmount){
                                cout<<"Not Enough Funds"<<endl;
                                goto two;
                                }
                                cout<<withdrawalAmount<<" $ has been withdrawed from account  "<<account_number.at(i) <<endl;
                                balance.at(i)-=withdrawalAmount;
                                cout<<"New balance : "<<balance.at(i)<<endl;
                            }
                            cout<<"-------------------------------------------------------------------------------------"<<endl;
                    }
                    else
                    {
                        cout<<"Invalid Account number "<<endl;
                    }
            }
}

void  averageBalance(vector<int> &balance)
{
    int sum_balance(0),average_balance(0);
    for(int i=0;i<=sizeCounter;i++)
            {
                sum_balance+=balance.at(i);
            }
    average_balance=sum_balance/(sizeCounter-1);
    cout<<"Average Balance in all "<<sizeCounter<<" accounts  are : "<<  average_balance <<"$"<<endl;
}

void  totalBalance(vector<int> &balance)
{
    int sum_balance(0);
    for(int i=0;i<sizeCounter;i++)
            {
                sum_balance+=balance.at(i);
            }
    cout<<"Total Balance in all "<<sizeCounter<<" accounts  are : "<<  sum_balance <<"$"<<endl;
}

void sortAccounts(vector<string> &firstName ,vector<string> &lastName,vector<int> &balance, vector<int> &account_number)
{
    int i,j,option(0);
    cout<<"Press 1 to sort Accoording to Balance in ascending order"<<endl; 
    cout<<"Press 2 to sort Accoording to First name ascending order"<<endl;  
    cout<<"Press 3 to sort Accoording to Last name ascending order"<<endl;
    cin>>option;
     while (cin.fail() || cin.peek() != '\n')
                        {
                            cin.clear();
                            cin.ignore(512, '\n');
                            cout << "Warning , Enter integers !: ";
                            cin >>option;
                        }
    if(option==1){
    for(i=0;i<sizeCounter;i++)
    {
        for(j=0;j<sizeCounter;j++)
        {
            if(balance.at(j)>balance.at(i))
            {
                int temp(0);
                temp=balance.at(i);
                balance.at(i)=balance.at(j);
                balance.at(j)=temp;
                
                string tempOne;
               tempOne=firstName.at(i);
                firstName.at(i)=firstName.at(j);
                firstName.at(j)=tempOne;
                
                string tempTwo;
               tempTwo=lastName.at(i);
                lastName.at(i)=lastName.at(j);
                lastName.at(j)=tempTwo;
            }
        }
    }
    }
    
    if(option==2){
      cout<<"Processing";
                    for(int i=0;i<sizeCounter;i++)
                    {
                        for(int j=0;j<sizeCounter-i-1;j++)
                        {   cout<<j;
                            if(compare(firstName[j],firstName[j+1]))
                            {
                            int swap;
                            string stringSwap;
                            swap=account_number[j];
                            account_number[j]=account_number[j+1];
                            account_number[j+1]=swap;
                            swap=balance[j];
                            balance[j]=balance[j+1];
                            balance[j+1]=swap;
                            stringSwap=firstName[j];
                            firstName[j]=firstName[j+1];
                            firstName[j+1]=stringSwap;
                            stringSwap=lastName[j];
                            lastName[j]=lastName[j+1];
                            lastName[j+1]=stringSwap;
                            }
                        }
                    }
                   // continue;
                }
        if(option==3){
            
             cout<<"Processing";
                    for(int i=0;i<sizeCounter;i++)
                    {
                        for(int j=0;j<sizeCounter-i-1;j++)
                        {   cout<<j;
                            if(compare(lastName[j],lastName[j+1]))
                            {
                            int swap;
                            string stringSwap;
                            swap=account_number[j];
                            account_number[j]=account_number[j+1];
                            account_number[j+1]=swap;
                            swap=balance[j];
                            balance[j]=balance[j+1];
                            balance[j+1]=swap;
                            stringSwap=firstName[j];
                            firstName[j]=firstName[j+1];
                            firstName[j+1]=stringSwap;
                            stringSwap=lastName[j];
                            lastName[j]=lastName[j+1];
                            lastName[j+1]=stringSwap;
                            }
                        }
                    }
                }
        cout<<"Details of Customer  "<<endl;
        cout<<"-------------------------------------------------------------------------------------"<<endl;
        cout<<"FirstName \tLastName\t AccountNumber \tBalance "<<endl;
           for(int i=0;i<sizeCounter;i++)
            {
                        cout<<firstName.at(i)<< " \t " <<lastName.at(i)<< " \t  " <<account_number.at(i)<< " \t " <<balance.at(i)<<endl;
            }
        cout<<"-------------------------------------------------------------------------------------"<<endl;
}

void deleteAccount(vector<string> &firstName ,vector<string> &lastName, vector<int> &account_number,vector<int> &balance)
{
    int accountNumber,i(0),j(0),count(0);
    cout<<"Enter Account number of the account to be delete : ";
	cin>>accountNumber;
    while (cin.fail() || cin.peek() != '\n')
                        {
                            cin.clear();
                            cin.ignore(512, '\n');
                            cout << "Warning , Enter digits !: ";
                            cin >>accountNumber;
                        }
	for(i=0; i<sizeCounter; i++)
	{
		if(account_number.at(i)==accountNumber)
		{
			for(j=0; j<sizeCounter; j++)
			{
				account_number.at(j)=account_number.at(j+1);
                firstName.at(j)=firstName.at(j+1);
                lastName.at(j)=lastName.at(j+1);
                balance.at(j)=balance.at(j+1);
			}
			count++;
			break;
		}
	}
	if(count==0)
	{
		cout<<"Account  not found..!!"<<endl;
	}
	else
	{
		cout<<"Account  deleted successfully..!!"<<endl;
        cout<<"Balance \t FirstName\tLastName\t AccountNumber "<<endl;
			for(int i=0;i<sizeCounter-del-1;i++)
            {
                        cout<<balance.at(i)<<"  \t  "<<firstName.at(i)<<"  \t   "<<lastName.at(i)<<"  \t  "<<account_number.at(i)<<endl;
            }
            del++;
	}
}

int compare(string s1,string s2)
{

    for(int i=0;s1[i]!='\0';i++)
    {
        int tempOne=(int)(s1[i]);
                if(tempOne>=67 &&tempOne<=90)
        {
           tempOne+=32;
        }
        s1[i]=(char)(tempOne);
                
    }
    for(int i=0;s2[i]!='\0';i++)
    {
        
        int tempOne=(int)(s2[i]);
        if(tempOne>=67 &&tempOne<=90)
        {
           tempOne+=32;
        }
                
        s2[i]=(char)(tempOne);
                
    }
    
    for(int j=0;s1[j]!='\0',s2[j]!='\0';j++)
    {
        if(s1[j]==s2[j])
        {
            continue;
        }
        
        else{
            if((int)s1[j]<(int)s2[j])
                return 0;
                else
                 return 1;
  
        }
    }
}    
bool isDigit(char check)
    {
            if((check>='0') && (check<='9'))
            {
                return true;
            }
           
           
                return false;
    }





    
    
    
    
