using System;

namespace OOP_FINAL_PROJECT
{
    // ══════════════════════════════════════════════════════════════
    //  SessionManager — Static event bus for real-time updates
    //  Any form can fire OrderChanged and ALL open forms will
    //  receive it instantly without polling or closing.
    // ══════════════════════════════════════════════════════════════
    public static class SessionManager
    {
        // Fired whenever an order is created or its status changes
        public static event Action OrderChanged;
        public static void NotifyOrderChanged() => OrderChanged?.Invoke();

        // Fired whenever Cook toggles menu item availability
        public static event Action MenuChanged;
        public static void NotifyMenuChanged() => MenuChanged?.Invoke();
    }
}