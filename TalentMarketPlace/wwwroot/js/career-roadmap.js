/**
 * Career Roadmap JavaScript interop helpers
 */

/**
 * Attach Enter key listener to career goal textarea.
 * Prevents default newline on Enter and triggers the Generate Roadmap function.
 * @param {HTMLElement} element - The textarea element
 */
window.attachCareerGoalEnterListener = function(element) {
    if (!element) {
        console.warn("Career goal element not found");
        return;
    }

    element.addEventListener('keydown', function(event) {
        // If Enter is pressed without Shift
        if (event.key === 'Enter' && !event.shiftKey) {
            event.preventDefault();
            
            // Find and click the "Generate Roadmap" button
            const generateButton = document.querySelector('button:has(span:contains("Generate Roadmap")), button[onclick*="GenerateRoadmap"]');
            
            // Alternative: look for button with the AutoAwesome icon
            const buttons = Array.from(document.querySelectorAll('button'));
            const roadmapButton = buttons.find(btn => {
                const text = btn.textContent;
                return text.includes('Generate Roadmap') || text.includes('Analyzing') || text.includes('Consulting AI');
            });
            
            if (roadmapButton && !roadmapButton.disabled) {
                roadmapButton.click();
            } else {
                console.warn("Generate Roadmap button not found or is disabled");
            }
        }
    });
};
