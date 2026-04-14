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

        // Call this from any form after placing/updating an order
        public static void NotifyOrderChanged()
        {
            OrderChanged?.Invoke();
        }
    }
}