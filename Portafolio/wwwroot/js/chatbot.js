document.addEventListener("DOMContentLoaded", () => {
    const toggleButton = document.getElementById("chat-toggle");
    const chatPopup = document.getElementById("chat-popup");
    const input = document.getElementById("chat-input");
    const sendButton = document.getElementById("chat-send");
    const messages = document.getElementById("chat-messages");

    // Abrir/cerrar el chat
    toggleButton.addEventListener("click", () => {
        chatPopup.classList.toggle("hidden");
    });

    async function sendMessage() {
        const query = input.value.trim();
        if (!query) return;

        messages.innerHTML += `<div class="user-message">${query}</div>`;
        input.value = "";

        // “Escribiendo...”
        const typingIndicator = document.createElement("div");
        typingIndicator.classList.add("typing-indicator");
        typingIndicator.innerHTML = `
            <span class="typing-dots"></span>
            <span class="typing-dots"></span>
            <span class="typing-dots"></span>
        `;
        messages.appendChild(typingIndicator);
        messages.scrollTop = messages.scrollHeight;

        try {
            const response = await fetch("https://chatbot-flask-production-3a74.up.railway.app/chat", {
                method: "POST",
                headers: { "Content-Type": "application/json" },
                body: JSON.stringify({ query })
            });
            const data = await response.json();

            typingIndicator.remove();
            messages.innerHTML += `<div class="bot-message">${data.answer}</div>`;
            messages.scrollTop = messages.scrollHeight;
        } catch (err) {
            typingIndicator.remove();
            messages.innerHTML += `<div class="bot-message error">Error: ${err}</div>`;
        }
    }

    // Enviar con botón
    sendButton.addEventListener("click", sendMessage);

    // Enviar con Enter
    input.addEventListener("keydown", (e) => {
        if (e.key === "Enter" && !e.shiftKey) {
            e.preventDefault();
            sendMessage();
        }
    });
});

