namespace DL;

public interface IMRepo{
    List<Storefront> GetAllStorefronts();

    Task<List<Storefront>> GetAllStorefrontsAsync();

    List<Customer> GetAllCustomers();

    Task<List<Customer>> GetAllCustomersAsync();
    List<Inventory> GetAllInventories();

    Task<List<Inventory>> GetAllInventoriesAsync();

    void AddStorefront(string _name, string _address, int _inventory);

    void AddInventory(int idOfItem, int amount);

    void ReplenishStock(int idOfItem, int idOfInventory, int numberToAdd);
    void PlaceAnOrder(int idOfItem, int numberOfItems, int stoId, int cusId);
    void AddCustomer(string _username, string _email, string _password);
    void PutCOHIDIntoCustomer(int cid, int id);
    void PutSOHIDIntoStorefront(int sid, int id);
    void PutOHInCOrderHistory(int ohId, int id);
    void PutOHInSOrderHistory(int ohId, int id);
    Customer GetCustomerByID(int id);
    Storefront GetStorefrontByID(int id);
    Product GetProductByID(int id);
    bool Login(string name, string email, string password);
    void AddProduct(int proID, string proTitle, decimal proPrice, int proYear, int proDirector, int proRating);
    void AddDirectorToProduct(int pid, string ndirector);
    void AddReleaseYearToProduct(int pid, int nyear);
    void AddRatingToProduct(int pid, string nrating);
    void DeleteCustomer(string username);
    void DeleteStorefront(string storename);
    void DeleteProduct(string _productname);
    void DeleteOrder(int oid);
    void DeleteInventory(int iId);
    List<Product> GetInventory(int _storeid);
    List<Order> GetOrdersDate();
    List<Order> GetOrdersCost();
    List<Order> GetCustomerOrderHistoryDate(int _userid);
    List<Order> GetCustomerOrderHistoryCost(int _userid);
    List<Order> GetStorefrontOrderHistoryDate(int _storeid);
    List<Order> GetStorefrontOrderHistoryCost(int _storeid);
    bool IsStorefrontDuplicate(Storefront newStorefront);
    bool IsCustomerDuplicate(Customer newCustomer);
}