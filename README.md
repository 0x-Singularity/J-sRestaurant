```
     _  _       ____           _                              _
    | |( )___  |  _ \ ___  ___| |_ __ _ _   _ _ __ __ _ _ __ | |_
 _  | | // __| | |_) / _ \/ __| __/ _` | | | | '__/ _` | '_ \| __|
| |_| |  \__ \ |  _ <  __/\__ \ || (_| | |_| | | | (_| | | | | |_
 \___/   |___/ |_| \_\___||___/\__\__,_|\__,_|_|  \__,_|_| |_|\__|

```

---

# Questions from our client interview:

## GUI

Which other apps have you used before? (unanswered)
Do you prefer simplicity and a minimalistic UI, or something more complex but all on one page? (read Meeting info, GUI)
Does the font need to be big or small? (Any particular lettering fonts that catch the clients attention or any recommendation(s)) (unanswered)
What colors would match the aesthetic of your restaurant? (read Meeting info, GUI)
How would you like your daily and yearly data represented? Sales, profit, menu item popularity, etc. (read meeting info, Restaurant Data)

## Software Architecture

If you have one, what application do you currently have in place? (unanswered)
Should our software be running on a configured POS system, or on a desktop style machine? (read Meetin info, In-Restaurant Info)

## Data Storage

What do you require for data storage and deletion? (unanswered)
Will the data be stored locally or remote? (read Meeting info, Data and Security)
If remote, are you using a cloud based solution? (unanswered)

## Functionality

Are there any specific functionalities that you want implemented for the end user’s experience? Ordering system, customer sees menu, staff sees order of customer
What are the basic functions needed for the product?
What functions would you love to have on the product but aren’t considered necessary?
What configurable features do you require? (catering is nice, but next release)
Should the customer be given the option to rate their waiters? Wait staff go back and forth to tables
If a customer wants to leave a tip should the customer be given specific percentage tip amounts or a custom tip option? (read Meeting info, In-Restaurant Info)
What about seasonal items? (unanswered)

## Instructional Documentation

What would make reading the documentation and instructions for our system easier for you to understand and use? Better to be with sufficient detail, that being video or documentation package to learn system (read Meeting info, Training)

## Security

Is there a security protocol or authentication you prefer? (read Meeting info, Data and Security)
Will cash be handled at the terminals or only credit cards? (read Meeting info, In-Restaurant Info)
Will there be an admin account with exclusive privileges? (read Meeting info, Data and Security)
In case of a system break(error) from an unknown person or bug/glitch should there be a system shutdown or lockdown in place? (unanswered)
In case of a system shutdown, should we implement a feature that allows you to keep track of information on paper until the system is back online? yes, (read Meeting info, Data and Security)

## Notes from the Interview:

---

## GUI:

Think about which language to develop in (I think we came to the conclusion of C# because of ease of GUI)
GUIs will be necessary, Prefers a more simple UI/more minimalistic
Restaurant Description: Combo of Modern and Rustic, like expensive burger places. Large glass windows around 3 sides, cedar planks, back wall is kitchen (combo of cedar planks and drywall).

## Restaurant Data:

Daily report: Sales, top 5/ bottom 5 items.
Numbers and Graphs for data representation, prefers numbers to graphs

## Data and Security:

System needs to be wired (including internet connection). The administrator account needs 2FA, staff just needs user/pass.
Log in systems, one logs in one logs out. Admin and staff password resets for forgetfulness. Associate staff with username and pass. No 2FA for staff, only admin.
Admin account can change/add/drop menu items and prices, assign/add/drop staff
Don’t accept logins until turned on.
Customer records, need info for carry out, once used hold onto for future use.
We recommend data storing locally or remotely later on (look at best short/long term. Look at training for storing data in the cloud).
Back up service system is required, POS stops and is written on paper, with register still functional without application management

## In-Restaurant Info:

Each table needs to have a status(clean, dirty, needs to be bussed,etc.). Fixed terminals (receipts need to be generate-able)
Management, kitchen staff, wait staff, host staff, bartending staff
A fixed terminal, all receipt printing and information input there
Inventory management is not necessary for this project or scheduling system
Customers pay in the restaurant.
This is a local app for restaurant use alone.
Tipping required, provide percentages and provide custom tip option (something like a steak house receipt?)
Restaurant deals in cash, credit, and checks. Systems must be put in place to deal with all 3.

## Training:

Training documentation is better if it has sufficient detail, that being video or documentation package to learn system

For more questions, don’t make assumptions. Email and send to Prof or set up new meeting or office hours.
