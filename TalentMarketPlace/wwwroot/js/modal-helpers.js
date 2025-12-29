// Modal Helper Functions for Razor Components
// Provides utilities for showing and hiding Bootstrap modals

/**
 * Show a Bootstrap modal by ID
 * @param {string} modalId - The ID of the modal element
 */
window.showModal = function(modalId) {
    const modalElement = document.getElementById(modalId);
    if (modalElement) {
        const modal = new bootstrap.Modal(modalElement, {
            backdrop: 'static',
            keyboard: false
        });
        modal.show();
    } else {
        console.warn(`Modal with ID '${modalId}' not found`);
    }
};

/**
 * Hide a Bootstrap modal by ID
 * @param {string} modalId - The ID of the modal element
 */
window.hideModal = function(modalId) {
    const modalElement = document.getElementById(modalId);
    if (modalElement) {
        const modal = bootstrap.Modal.getInstance(modalElement);
        if (modal) {
            modal.hide();
        }
    }
};

/**
 * Toggle a Bootstrap modal by ID
 * @param {string} modalId - The ID of the modal element
 */
window.toggleModal = function(modalId) {
    const modalElement = document.getElementById(modalId);
    if (modalElement) {
        const modal = bootstrap.Modal.getInstance(modalElement);
        if (modal) {
            modal.toggle();
        } else {
            const newModal = new bootstrap.Modal(modalElement);
            newModal.show();
        }
    }
};

/**
 * Scroll modal content to top
 * @param {string} modalId - The ID of the modal element
 */
window.scrollModalToTop = function(modalId) {
    const modalElement = document.getElementById(modalId);
    if (modalElement) {
        const scrollableContent = modalElement.querySelector('.modal-dialog-scrollable');
        if (scrollableContent) {
            scrollableContent.scrollTop = 0;
        }
    }
};

/**
 * Check if a modal is currently visible
 * @param {string} modalId - The ID of the modal element
 * @returns {boolean} - True if modal is visible
 */
window.isModalVisible = function(modalId) {
    const modalElement = document.getElementById(modalId);
    if (modalElement) {
        return modalElement.classList.contains('show');
    }
    return false;
};

console.log('[Modal Helpers] Modal utility functions loaded successfully');
