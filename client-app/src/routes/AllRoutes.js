import { Routes, Route } from "react-router-dom"
import { Home, About } from "../pages/index"
export const AllRoutes = () => {
    return (
        <Routes>
            <Route path="/" element={<Home />} />
            <Route path="about" element={<About />} />
        </Routes>);
};
