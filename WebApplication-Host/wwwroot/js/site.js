document.addEventListener("DOMContentLoaded", function () {
    const themeSwitchBtn = document.querySelector('#theme-switch-btn');

    // Load saved theme
    const currentTheme = localStorage.getItem('theme');
    if (currentTheme) {
        document.body.classList.toggle('dark-mode', currentTheme === 'dark');
        themeSwitchBtn.textContent = currentTheme === 'dark' ? 'Light Mode' : 'Dark Mode';
    }

    // Toggle theme on button click
    themeSwitchBtn.addEventListener('click', function () {
        const isDarkMode = document.body.classList.toggle('dark-mode');
        themeSwitchBtn.textContent = isDarkMode ? 'Light Mode' : 'Dark Mode';
        const theme = isDarkMode ? 'dark' : 'light';
        localStorage.setItem('theme', theme);
    });
});
