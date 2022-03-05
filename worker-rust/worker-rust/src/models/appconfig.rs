#[derive(Default)]
pub struct AppConfig {
    pub sales_timer: Option<i32>,
    pub item_timer: Option<i32>,
    pub purchase_timer: Option<i32>,
    pub vendor_timer: Option<i32>,

    pub base_urls : Option<String>

}

impl AppConfig {
    // Mutable access.
    pub fn sales_timer_mut(&mut self) -> &mut Option<i32> {
        &mut self.sales_timer
    }

    // Mutable access.
    pub fn item_timer_mut(&mut self) -> &mut Option<i32> {
        &mut self.item_timer
    }

    // Mutable access.
    pub fn purchase_timer_mut(&mut self) -> &mut Option<i32> {
        &mut self.purchase_timer
    }

    // Mutable access.
    pub fn vendor_timer_mut(&mut self) -> &mut Option<i32> {
        &mut self.vendor_timer
    }

    // Mutable access.
    pub fn base_urls_mut(&mut self) -> &mut Option<String> {
        &mut self.base_urls
    }
}