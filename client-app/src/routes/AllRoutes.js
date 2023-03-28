import { Routes, Route } from "react-router-dom"
import { Home, About, Blog } from "../pages/index"
export const AllRoutes = () => {
    return (
        <Routes>
            <Route path="/" element={<Home />} />
            <Route path="/about" element={<About />} />
            <Route path="/blog:id" element={<Blog />} />
        </Routes>);
};
