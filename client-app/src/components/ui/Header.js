import React, { useState } from 'react'
import { Link } from "react-router-dom";

export const Header = ({ activeLink, setActiveLink }) => {


    return (
        <nav className="navbar navbar-expand-lg navbar-default navbar-custom navbar-light">
            <div className="container">
                <a className="navbar-brand logo" href="index.html"><i className="icofont-deer-head"></i></a>

                <div className="navbar-header">

                    <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbar-collapse-1"
                        aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                        <span className="pe-7s-menu"></span>
                    </button>
                </div>

                <div className="collapse navbar-collapse" id="navbar-collapse-1">
                    <ul className="nav navbar-nav ms-auto">
                        <li className={`nav-item ${activeLink == "home" ? "active-item" : ""}`}><Link className="nav-link" to="/" onClick={() => { setActiveLink("home"); console.log("home"); }}>Home</Link></li>
                        <li className={`nav-item ${activeLink == "about" ? "active-item" : ""}`}><Link className="nav-link" to="/about" onClick={() => { setActiveLink("about"); console.log("about"); }}>About</Link></li>
                        <li className="nav-item"><a className="nav-link" href="services.html">Services</a></li>
                        <li className="nav-item"><a className="nav-link" href="work.html">Work</a></li>
                        <li className="nav-item"><a className="nav-link" href="blog.html">Blog</a></li>
                        <li className="nav-item"><a className="nav-link" href="contact.html">Contact</a></li>
                    </ul>
                </div>

            </div>
        </nav>
    )
}
