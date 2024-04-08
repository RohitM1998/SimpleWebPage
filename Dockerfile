# Use the official Nginx image as the base image
FROM nginx:latest

# Copy the HTML and CSS files from the host into the Nginx web server's root directory
COPY ./ /usr/share/nginx/html

# Expose port 87 to allow outside access to your web server
EXPOSE 87
